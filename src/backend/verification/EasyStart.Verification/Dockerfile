FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER $APP_UID
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["src/backend/verification/EasyStart.Verification/EasyStart.Verification.csproj", "src/backend/verification/EasyStart.Verification/"]
RUN dotnet restore "src/backend/verification/EasyStart.Verification/EasyStart.Verification.csproj"
COPY . .
WORKDIR "/src/src/backend/verification/EasyStart.Verification"
RUN dotnet build "EasyStart.Verification.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "EasyStart.Verification.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "EasyStart.Verification.dll"]
