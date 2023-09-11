#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["APIGatewayMVC/APIGatewayMVC.csproj", "APIGatewayMVC/"]
COPY ["BLL/BLL.csproj", "BLL/"]
COPY ["DAL/DAL.csproj", "DAL/"]
COPY ["Models/Models.csproj", "Models/"]
COPY ["UnitTests/UnitTests.csproj", "UnitTests"]

RUN dotnet restore "APIGatewayMVC/APIGatewayMVC.csproj"

COPY . .
WORKDIR "/src/APIGatewayMVC"
RUN dotnet build "APIGatewayMVC.csproj" -c Release -o /app/build

FROM build AS test  
ARG BuildId
LABEL test=true
WORKDIR "/src/UnitTests"
RUN dotnet test --logger "trx;logfilename=testresults.trx"

FROM build AS publish
WORKDIR "/src/APIGatewayMVC"
RUN dotnet publish "APIGatewayMVC.csproj" -c Release -o /app/publish /p:UseAppHost=false  

FROM base AS final
WORKDIR /app
COPY --from=test /src/UnitTests/TestResults/testresults.trx testresults/testresults.trx
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "APIGatewayMVC.dll"]