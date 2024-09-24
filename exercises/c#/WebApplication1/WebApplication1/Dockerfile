# Etapa 1: Build da aplicação
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copia os arquivos de projeto para o contêiner
COPY . .

# Restaura as dependências do projeto
RUN dotnet restore

# Faz o build do projeto
RUN dotnet publish -c Release -o /app

# Etapa 2: Configuração do contêiner para execução
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app

# Copia os arquivos construídos da etapa anterior
COPY --from=build /app .

# Expor a porta onde o aplicativo estará rodando
EXPOSE 80

# Comando para iniciar o aplicativo
ENTRYPOINT ["dotnet", "WebApplication1.dll"]
