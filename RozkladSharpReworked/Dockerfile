FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["RozkladSharpReworked/RozkladSharpReworked.csproj", "RozkladSharpReworked/"]
RUN dotnet restore "RozkladSharpReworked/RozkladSharpReworked.csproj"
COPY . .
WORKDIR "/src/RozkladSharpReworked"
RUN dotnet build "RozkladSharpReworked.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "RozkladSharpReworked.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "RozkladSharpReworked.dll"]
