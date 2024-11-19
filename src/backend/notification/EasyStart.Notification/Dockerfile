FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER $APP_UID
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["src/backend/notification/EasyStart.Notification/EasyStart.Notification.csproj", "src/backend/notification/EasyStart.Notification/"]
RUN dotnet restore "src/backend/notification/EasyStart.Notification/EasyStart.Notification.csproj"
COPY . .
WORKDIR "/src/src/backend/notification/EasyStart.Notification"
RUN dotnet build "EasyStart.Notification.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "EasyStart.Notification.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "EasyStart.Notification.dll"]
