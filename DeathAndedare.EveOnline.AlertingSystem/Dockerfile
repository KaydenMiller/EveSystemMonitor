FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER $APP_UID
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["DeathAndedare.EveOnline.AlertingSystem/DeathAndedare.EveOnline.AlertingSystem.csproj", "DeathAndedare.EveOnline.AlertingSystem/"]
RUN dotnet restore "DeathAndedare.EveOnline.AlertingSystem/DeathAndedare.EveOnline.AlertingSystem.csproj"
COPY . .
WORKDIR "/src/DeathAndedare.EveOnline.AlertingSystem"
RUN dotnet build "DeathAndedare.EveOnline.AlertingSystem.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "DeathAndedare.EveOnline.AlertingSystem.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "DeathAndedare.EveOnline.AlertingSystem.dll"]
