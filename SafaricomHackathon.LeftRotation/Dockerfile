FROM mcr.microsoft.com/dotnet/core/runtime:2.2-stretch-slim AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["SafaricomHackathon.LeftRotation/SafaricomHackathon.LeftRotation.csproj", "SafaricomHackathon.LeftRotation/"]
RUN dotnet restore "SafaricomHackathon.LeftRotation/SafaricomHackathon.LeftRotation.csproj"
COPY . .
WORKDIR "/src/SafaricomHackathon.LeftRotation"
RUN dotnet build "SafaricomHackathon.LeftRotation.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "SafaricomHackathon.LeftRotation.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "SafaricomHackathon.LeftRotation.dll"]
