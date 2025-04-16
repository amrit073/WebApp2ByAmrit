FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /app

# Create a project directory
RUN mkdir -p /app/WebApp2ByAmrit

# Copy everything to the app directory
COPY . ./WebApp2ByAmrit/

# Set working directory to the project directory
WORKDIR /app/WebApp2ByAmrit

# Restore dependencies
RUN dotnet restore

# Build and publish
RUN dotnet publish -c Release -o /app/publish

# Build runtime image
FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /app
COPY --from=build /app/publish .

# Expose port and set entry point
EXPOSE 80
EXPOSE 443
ENTRYPOINT ["dotnet", "WebApp2ByAmrit.dll"] 