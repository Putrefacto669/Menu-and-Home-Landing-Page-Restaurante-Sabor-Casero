# ---------- Etapa de compilación ----------
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Restaurar dependencias primero (aprovecha la caché de capas)
COPY RestauranteSaborCasero.csproj ./
RUN dotnet restore RestauranteSaborCasero.csproj

# Copiar el resto del código y publicar
COPY . .
RUN dotnet publish RestauranteSaborCasero.csproj -c Release -o /app/publish --no-restore /p:UseAppHost=false

# ---------- Etapa de ejecución ----------
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
WORKDIR /app
COPY --from=build /app/publish .

ENV ASPNETCORE_ENVIRONMENT=Production
# Render inyecta la variable PORT; si no existe, se usa 8080
EXPOSE 8080
USER app
ENTRYPOINT ["sh", "-c", "ASPNETCORE_URLS=http://0.0.0.0:${PORT:-8080} exec dotnet RestauranteSaborCasero.dll"]
