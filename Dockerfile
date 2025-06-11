# Etapa de build con .NET 8 SDK
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copia todo el código
COPY . .

# Restaura dependencias
RUN dotnet restore

# Publica la aplicación
RUN dotnet publish -c Release -o /app/publish

# Etapa final con solo el runtime
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
WORKDIR /app
COPY --from=build /app/publish .

# Expone el puerto 80
EXPOSE 80

# Cambia 'ReiNona.dll' si tu proyecto tiene otro nombre
ENTRYPOINT ["dotnet", "ReiNona.dll"]
