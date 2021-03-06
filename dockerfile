# FROM mcr.microsoft.com/dotnet/core/sdk:3.0 AS build
FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
WORKDIR /source

# copy csproj and restore as distinct layers
# COPY *.sln ./
COPY dndb.Cards.Bot/*.csproj ./dndb.Cards.Bot/
COPY dndb.Cards.Parser/*.csproj ./dndb.Cards.Parser/
COPY dndb.Cards.Pdf/*.csproj ./dndb.Cards.Pdf/
RUN dotnet restore dndb.Cards.Bot/*.csproj

COPY dndb.Cards.Bot/ dndb.Cards.Bot/
COPY dndb.Cards.Parser/ dndb.Cards.Parser/
COPY dndb.Cards.Pdf/ dndb.Cards.Pdf/
 

WORKDIR /source/dndb.Cards.Bot
RUN dotnet build -c release --no-restore

FROM build AS publish
RUN dotnet publish -c release --no-build -o /app

# final stage/image
FROM mcr.microsoft.com/dotnet/core/runtime:3.1
# install System.Drawing native dependencies
RUN apt-get update \
    && apt-get install -y --allow-unauthenticated \
        libc6-dev \
        libgdiplus \
        libx11-dev \
     && rm -rf /var/lib/apt/lists/*

WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "dndb.Cards.Bot.dll"]
