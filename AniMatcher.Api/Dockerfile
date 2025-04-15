FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
EXPOSE 80
EXPOSE 443
COPY ["AniMatcher.Api/AniMatcher.Api.csproj", "AniMatcher.Api/"]
RUN dotnet restore "AniMatcher.Api/AniMatcher.Api.csproj"
COPY . .
WORKDIR "/src/AniMatcher.Api"
RUN dotnet build "AniMatcher.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "AniMatcher.Api.csproj" -c Release -o /app/publish

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "AniMatcher.Api.dll"]