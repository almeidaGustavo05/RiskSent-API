FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build-env
WORKDIR /app

COPY *.sln ./
COPY RiskRent.API/*.csproj ./RiskRent.API/
COPY RiskRent.Application/*.csproj ./RiskRent.Application/
COPY RiskRent.Domain/*.csproj ./RiskRent.Domain/
COPY RiskRent.Infrastructure/*.csproj ./RiskRent.Infrastructure/

RUN dotnet restore

COPY . ./

RUN dotnet publish RiskRent.API/RiskRent.API.csproj -c Release -o out

FROM mcr.microsoft.com/dotnet/aspnet:9.0
WORKDIR /app
COPY --from=build-env /app/out .

EXPOSE 80
EXPOSE 443

ENV LANG pt_BR.UTF-8
ENV ASPNETCORE_URLS=http://+:80

CMD ["dotnet", "RiskRent.API.dll"]