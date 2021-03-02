#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
ENV ASPNETCORE_URLS=http://+:8000 
EXPOSE 5000
EXPOSE 8000

WORKDIR /app
COPY . /app
ENTRYPOINT ["dotnet", "PMS.WebApi.dll"]