#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
#EXPOSE 80
#EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Quest.Api/Quest.Api/Quest.Api.csproj", "Quest.Api/Quest.Api/"]
RUN dotnet restore "Quest.Api/Quest.Api/Quest.Api.csproj"
COPY . .
WORKDIR "/src/Quest.Api/Quest.Api"
RUN dotnet build "Quest.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Quest.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
#ENTRYPOINT ["dotnet", "Quest.Api.dll"]
CMD ASPNETCORE_URLS=http://*:$PORT dotnet Quest.Api.dll