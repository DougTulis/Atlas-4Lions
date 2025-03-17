# Etapa de build
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build-env
WORKDIR /app

# Copia tudo dentro da pasta API (já incluindo dependências)
COPY ../ .

# Restaura pacotes
RUN dotnet restore Projeto_ATLAS_4LIONS.API.csproj

# Compila e publica a API
RUN dotnet publish Projeto_ATLAS_4LIONS.API.csproj -c Release -o out

# Criar a imagem final
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build-env /app/out .

EXPOSE 80
ENTRYPOINT ["dotnet", "Projeto_ATLAS_4LIONS.API.dll"]
