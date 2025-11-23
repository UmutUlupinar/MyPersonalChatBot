# ChatBot API - .NET 10 Minimal API

Bu proje, OpenAI API kullanarak kişisel bir chatbot oluşturan minimal bir .NET 10 API'sidir.

## Özellikler

- ✅ Minimal API yapısı (.NET 10)
- ✅ OpenAI API entegrasyonu (gpt-4o-mini)
- ✅ IP bazlı rate limiting (1 saniyede 1 istek)
- ✅ CORS desteği
- ✅ Prompt tabanlı bilgi sistemi
- ✅ CV ve örnek cevaplar ile kişiselleştirilmiş yanıtlar

## Kurulum

### 1. Projeyi Klonlayın

```bash
git clone <repo-url>
cd ChatBotApi
```

### 2. Prompt Dosyalarını Düzenleyin

`prompts/` klasöründeki dosyaları düzenleyin:

- `base_rules.txt` - Bot kuralları
- `my_cv.txt` - CV bilgileriniz
- `sample_answers.txt` - Örnek soru-cevap çiftleri

### 3. API Key Yapılandırması

**Yerel Geliştirme:**
`appsettings.Development.json` dosyasına ekleyin:

```json
{
  "OpenAI": {
    "ApiKey": "sk-your-api-key-here",
    "Model": "gpt-4o-mini"
  }
}
```

**Production (Render.com):**
Environment Variables olarak ekleyin:
- `OPENAI_API_KEY` = sk-your-api-key-here

### 4. Projeyi Çalıştırın

```bash
dotnet run
```

API `http://localhost:5000` adresinde çalışacaktır.

## API Endpoints

### POST /ask

Kullanıcı sorusunu alır ve OpenAI API üzerinden cevap döner.

**Request:**
```json
{
  "question": "Hangi programlama dillerini biliyorsun?"
}
```

**Response:**
```json
{
  "answer": "C#, JavaScript, Python gibi dillerde çalışıyorum..."
}
```

### GET /health

API sağlık kontrolü.

**Response:**
```json
{
  "status": "ok"
}
```

## Rate Limiting

API, IP bazlı rate limiting kullanır:
- 1 saniyede maksimum 1 istek
- Limit aşılırsa `429 Too Many Requests` döner

## Render.com Deployment (Docker)

1. GitHub'a projeyi push edin
2. Render.com'da yeni **Web Service** oluşturun
3. GitHub repo'nuzu bağlayın
4. **Docker** seçeneğini seçin (Render otomatik olarak Dockerfile'ı bulacak)
5. Environment Variables ekleyin:
   - `OPENAI_API_KEY` = sk-your-api-key-here
   - `PORT` = 8080 (Render otomatik set eder, ama manuel de ekleyebilirsiniz)
6. Deploy edin!

**Not:** Render.com otomatik olarak Dockerfile'ı bulur ve build eder. Herhangi bir build/start command girmenize gerek yok.

## Notlar

- API key'i asla GitHub'a push etmeyin
- `appsettings.json` dosyası `.gitignore`'da olmalı
- Production'da environment variables kullanın
- Rate limiting memory'de tutulur (uyku modundan sonra sıfırlanır)

## Lisans

MIT

