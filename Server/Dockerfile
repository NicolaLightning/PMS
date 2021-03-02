#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["src/PMS.WebHost/PMS.Web.Host.csproj", "src/PMS.WebHost/"]
COPY ["src/PMS.Application/PMS.Application.csproj", "src/PMS.Application/"]
COPY ["src/PMS.Core/PMS.Core.csproj", "src/PMS.Core/"]
COPY ["src/PMS.CommonType/PMS.CommonType.csproj", "src/PMS.CommonType/"]
COPY ["src/PMS.Utility/PMS.Utility.csproj", "src/PMS.Utility/"]
COPY ["src/PMS.EntityFrameWorkCore/PMS.EntityFrameworkCore.csproj", "src/PMS.EntityFrameWorkCore/"]
RUN dotnet restore "src/PMS.WebHost/PMS.Web.Host.csproj"
COPY . .
WORKDIR "/src/src/PMS.WebHost"
RUN dotnet build "PMS.Web.Host.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "PMS.Web.Host.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "PMS.Web.Host.dll"]