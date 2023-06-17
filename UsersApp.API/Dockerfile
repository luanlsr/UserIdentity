#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["UsersApp.API/UsersApp.API.csproj", "UsersApp.API/"]
COPY ["UsersApp.Application/UsersApp.Application.csproj", "UsersApp.Application/"]
COPY ["UsersApp.Domain/UsersApp.Domain.csproj", "UsersApp.Domain/"]
COPY ["UsersApp.Infra.Data/UsersApp.Infra.Data.csproj", "UsersApp.Infra.Data/"]
COPY ["UsersApp.Infra.Identity/UsersApp.Infra.Identity.csproj", "UsersApp.Infra.Identity/"]
COPY ["UsersApp.Infra.Messages/UsersApp.Infra.Messages.csproj", "UsersApp.Infra.Messages/"]
RUN dotnet restore "UsersApp.API/UsersApp.API.csproj"
COPY . .
WORKDIR "/src/UsersApp.API"
RUN dotnet build "UsersApp.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "UsersApp.API.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "UsersApp.API.dll"]