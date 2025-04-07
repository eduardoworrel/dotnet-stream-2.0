# https://hub.docker.com/_/microsoft-dotnet
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build

WORKDIR /app

COPY . .
RUN dotnet publish -c Release -o /out api.csproj


# final stage/image
FROM mcr.microsoft.com/dotnet/aspnet:9.0

WORKDIR /app
COPY --from=build /out ./

ENV ENV_PROJECT_NAME "./api"

ENV ASPNETCORE_URLS "http://+:80"
EXPOSE 80

CMD $ENV_PROJECT_NAME