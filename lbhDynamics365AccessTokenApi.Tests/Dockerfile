FROM mcr.microsoft.com/dotnet/core/sdk:3.1

# disable microsoft telematry
ENV DOTNET_CLI_TELEMETRY_OPTOUT='true'

WORKDIR /app

# Copy csproj and restore as distinct layers
COPY ./lbhDynamics365AccessTokenApi.sln ./
COPY ./lbhDynamics365AccessTokenApi/lbhDynamics365AccessTokenApi.csproj ./lbhDynamics365AccessTokenApi/
COPY ./lbhDynamics365AccessTokenApi.Tests/lbhDynamics365AccessTokenApi.Tests.csproj ./lbhDynamics365AccessTokenApi.Tests/

RUN dotnet restore ./lbhDynamics365AccessTokenApi/lbhDynamics365AccessTokenApi.csproj
RUN dotnet restore ./lbhDynamics365AccessTokenApi.Tests/lbhDynamics365AccessTokenApi.Tests.csproj

# Copy everything else and build
COPY . .

RUN dotnet build -c debug -o out lbhDynamics365AccessTokenApi.Tests/lbhDynamics365AccessTokenApi.Tests.csproj

CMD dotnet test
