# Usa a imagem runtime do .NET 8 para rodar a aplicação
FROM mcr.microsoft.com/dotnet/aspnet:8.0  
WORKDIR /app  

# Copia os arquivos já publicados da pasta "out"
COPY out /app  

# Habilita arquivos estáticos
RUN mkdir -p /app/wwwroot
RUN cp -r /app/wwwroot/swagger /app/wwwroot

ENTRYPOINT ["dotnet", "Atlas-API.dll"]
