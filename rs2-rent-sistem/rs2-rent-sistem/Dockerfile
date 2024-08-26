FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 5119
ENV ASPNETCORE_URLS=http://+:5119

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["rs2-rent-sistem/rs2-rent-sistem.csproj", "rs2-rent-sistem/"]
RUN dotnet restore "rs2-rent-sistem/rs2-rent-sistem.csproj"
COPY . .
WORKDIR "/src/rs2-rent-sistem"
RUN dotnet build "rs2-rent-sistem.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "rs2-rent-sistem.csproj" -c Release -o /app/build

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "rs2-rent-sistem.dll"]