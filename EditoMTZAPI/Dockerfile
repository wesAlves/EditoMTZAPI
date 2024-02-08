FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER $APP_UID
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["EditoMTZAPI/EditoMTZAPI.csproj", "EditoMTZAPI/"]
RUN dotnet restore "EditoMTZAPI/EditoMTZAPI.csproj"
COPY . .
WORKDIR "/src/EditoMTZAPI"
RUN dotnet build "EditoMTZAPI.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "EditoMTZAPI.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "EditoMTZAPI.dll"]
