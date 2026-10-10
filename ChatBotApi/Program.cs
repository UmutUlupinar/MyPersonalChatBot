using System.Collections.Concurrent;
using System.Net;
using System.Text;
using System.Text.Json;

var builder = WebApplication.CreateBuilder(args);

// CORS yapılandırması
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
    {
        policy.AllowAnyOrigin()
              .AllowAnyMethod()
              .AllowAnyHeader();
    });
});

var app = builder.Build();

// CORS middleware
app.UseCors();

app.UseDefaultFiles();
app.UseStaticFiles();

// Rate limiting için basit bir dictionary (IP bazlı)
var rateLimitStore = new ConcurrentDictionary<string, DateTime>();
var rateLimitWindow = TimeSpan.FromSeconds(1); // 1 saniyede 1 istek

// Prompt dosyalarını oku ve birleştir
string LoadSystemPrompt()
{
    var baseRules = File.ReadAllText("prompts/base_rules.txt");
    var cv = File.ReadAllText("prompts/my_cv.txt");
    var sampleAnswers = File.ReadAllText("prompts/sample_answers.txt");
    var currentContext = File.ReadAllText("prompts/current_context.txt");
    var experienceDetails = File.ReadAllText("prompts/experience_details.txt");
    var faq = File.ReadAllText("prompts/faq.txt");
    var githubProjects = File.ReadAllText("prompts/github_projects.md");
    var interviewNotes = File.ReadAllText("prompts/interview_notes.txt");
    var technologyIndex = File.ReadAllText("prompts/technology_index.txt");
    var github = File.ReadAllText("prompts/github.txt");

    var turkeyTime = TimeZoneInfo.ConvertTimeBySystemTimeZoneId(
        DateTimeOffset.UtcNow,
        "Europe/Istanbul");
    var currentDate = turkeyTime.ToString("yyyy-MM-dd");

    return $@"{baseRules}

GÜNCEL TARİH:
{currentDate}

GÜNCEL BAĞLAM:
{currentContext}

CV BİLGİLERİ:
{cv}

DENEYİM DETAYLARI:
{experienceDetails}

TEKNOLOJİ İNDEKSİ:
{technologyIndex}

GITHUB PROJELERİ:
{githubProjects}

SIK SORULAN SORULAR:
{faq}

MÜLAKAT NOTLARI:
{interviewNotes}

ÖRNEK SORU-CEVAPLAR:
{sampleAnswers}

BU CHATBOT PROJESİ (GITHUB ÖZETİ):
{github}

Yukarıdaki bilgileri kullanarak soruları cevapla. CV'de olmayan bilgiler hakkında konuşma.";
}

// Rate limiting kontrolü
bool CheckRateLimit(string clientIp)
{
    var now = DateTime.UtcNow;
    
    if (rateLimitStore.TryGetValue(clientIp, out var lastRequest))
    {
        if (now - lastRequest < rateLimitWindow)
        {
            return false; // Rate limit aşıldı
        }
    }
    
    rateLimitStore[clientIp] = now;
    
    // Eski kayıtları temizle (memory leak önleme)
    var expiredKeys = rateLimitStore
        .Where(kvp => now - kvp.Value > TimeSpan.FromMinutes(5))
        .Select(kvp => kvp.Key)
        .ToList();
    
    foreach (var key in expiredKeys)
    {
        rateLimitStore.TryRemove(key, out _);
    }
    
    return true;
}

// Client IP'yi al
string GetClientIp(HttpContext context)
{
    return context.Connection.RemoteIpAddress?.ToString() ?? "unknown";
}

// Ana endpoint
app.MapPost("/ask", async (HttpContext context, AskRequest request) =>
{
    // Rate limiting kontrolü
    var clientIp = GetClientIp(context);
    if (!CheckRateLimit(clientIp))
    {
        context.Response.StatusCode = (int)HttpStatusCode.TooManyRequests;
        return Results.Json(new { error = "Çok fazla istek. Lütfen bekleyin." }, 
            statusCode: 429);
    }
    
    // API key kontrolü
    var apiKey = builder.Configuration["OpenAI:ApiKey"] ?? Environment.GetEnvironmentVariable("OPENAI_API_KEY");
    
    if (string.IsNullOrEmpty(apiKey))
    {
        context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
        return Results.Json(new { error = "OpenAI API key yapılandırılmamış." }, 
            statusCode: 500);
    }
    
    // Model adı
    var model = builder.Configuration["OpenAI:Model"] ?? "gpt-4o-mini";
    
    // System prompt'u yükle
    var systemPrompt = LoadSystemPrompt();
    
    try
    {
        // HttpClient ile OpenAI REST API'ye istek
        using var httpClient = new HttpClient();
        httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}");
        
        var requestBody = new
        {
             model = model,
             input = new[]
               {
                 new { role = "system", content = systemPrompt },
                 new { role = "user", content = request.Question ?? "" }
               },
             temperature = 0.3,          // 0-1 arası, düşük = daha tutarlı cevap
             top_p = 0.9,                 // nucleus sampling, opsiyonel
             max_output_tokens = 500
        };

        
        var json = JsonSerializer.Serialize(requestBody);
        var content = new StringContent(json, Encoding.UTF8, "application/json");
        
        var response = await httpClient.PostAsync(
            "https://api.openai.com/v1/responses", 
            content);
        
        if (!response.IsSuccessStatusCode)
        {
            var errorContent = await response.Content.ReadAsStringAsync();
            context.Response.StatusCode = (int)response.StatusCode;
            return Results.Json(new { error = $"OpenAI API hatası: {errorContent}" }, 
                statusCode: (int)response.StatusCode);
        }
        
        var responseContent = await response.Content.ReadAsStringAsync();
        
        var doc = JsonDocument.Parse(responseContent);

        var answer = doc.RootElement
            .GetProperty("output")[0]
            .GetProperty("content")[0]
            .GetProperty("text")
            .GetString();

        
        return Results.Json(new { answer = answer });
    }
    catch (Exception ex)
    {
        context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
        return Results.Json(new { error = $"Hata: {ex.Message}" }, 
            statusCode: 500);
    }
})
.WithName("Ask");

// Health check endpoint
app.MapGet("/health", () => Results.Json(new { status = "ok" }))
    .WithName("Health");

// Render.com için PORT environment variable'ını kullan
var port = Environment.GetEnvironmentVariable("PORT") ?? "8080";
app.Run($"http://0.0.0.0:{port}");

// Request model
record AskRequest(string? Question);
