FROM microsoft/aspnetcore-build:2.0 AS build-env
WORKDIR /app

# Copy csproj and restore as distinct layers
COPY src/ ./
#RUN dotnet restore

# Copy everything else and build
#COPY . ./
RUN dotnet publish -c Release -o out ./Uptime.Web/

# Build runtime image
FROM microsoft/aspnetcore:2.0
WORKDIR /app
COPY --from=build-env /app/Uptime.Web/out .
ENTRYPOINT ["dotnet", "Uptime.Web.dll"]