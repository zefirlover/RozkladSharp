FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["RozkladSharp.Frontend/RozkladSharp.Frontend.csproj", "RozkladSharp.Frontend/"]
RUN dotnet restore "RozkladSharp.Frontend/RozkladSharp.Frontend.csproj"
COPY . .
WORKDIR "/src/RozkladSharp.Frontend"
RUN dotnet build "RozkladSharp.Frontend.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "RozkladSharp.Frontend.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "RozkladSharp.Frontend.dll"]
