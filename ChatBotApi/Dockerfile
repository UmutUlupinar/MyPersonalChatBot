# Build stage
FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
WORKDIR /src

# Copy project file and restore dependencies
COPY ChatBotApi.csproj .
RUN dotnet restore

# Copy everything else and build
COPY . .
RUN dotnet build -c Release -o /app/build

# Publish stage
FROM build AS publish
RUN dotnet publish -c Release -o /app/publish /p:UseAppHost=false

# Runtime stage
FROM mcr.microsoft.com/dotnet/aspnet:10.0 AS final
WORKDIR /app

# Copy published app
COPY --from=publish /app/publish .

# Copy prompts folder (backup - should be included in publish, but ensuring it's there)
COPY --from=build /src/prompts ./prompts

# Expose port (Render.com will set PORT env var dynamically)
EXPOSE 8080

# Run the app
# Program.cs will read PORT env var from Render.com
ENTRYPOINT ["dotnet", "ChatBotApi.dll"]

