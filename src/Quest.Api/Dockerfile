#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /app

COPY ["src/Quest.Api/Quest.Api.csproj", "src/Quest.Api/"]
RUN dotnet restore "src/Quest.Api/Quest.Api.csproj"

COPY . .
WORKDIR "/app/src/Quest.Api"
RUN dotnet build "Quest.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Quest.Api.csproj" -c Release -o /app/publish

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
RUN mkdir -p /app/quest-api
WORKDIR /app/quest-api

COPY --from=publish /app/publish .
CMD ASPNETCORE_URLS=http://*:$PORT dotnet Quest.Api.dll #for heroku


#ENTRYPOINT ["dotnet", "Quest.Api.dll"]