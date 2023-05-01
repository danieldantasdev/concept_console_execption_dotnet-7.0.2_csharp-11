FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Exception/Exception.csproj", "Exception/"]
RUN dotnet restore "Exception/Exception.csproj"
COPY . .
WORKDIR "/src/Exception"
RUN dotnet build "Exception.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Exception.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Exception.dll"]
