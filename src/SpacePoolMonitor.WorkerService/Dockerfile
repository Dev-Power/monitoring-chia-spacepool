FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["SpacePoolMonitor.WorkerService/SpacePoolMonitor.WorkerService.csproj", "SpacePoolMonitor.WorkerService/"]
RUN dotnet restore "SpacePoolMonitor.WorkerService/SpacePoolMonitor.WorkerService.csproj"
COPY . .
WORKDIR "/src/SpacePoolMonitor.WorkerService"
RUN dotnet build "SpacePoolMonitor.WorkerService.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "SpacePoolMonitor.WorkerService.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SpacePoolMonitor.WorkerService.dll"]
