# -----------------------------------
# Stage 1: Build the .NET application
# -----------------------------------
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copy project files
COPY ExpenseTracker.csproj ./
RUN dotnet restore

# Copy rest of the app
COPY . ./

# Build
RUN dotnet publish -c Release -o /app/publish

# -----------------------------------
# Stage 2: Run the application
# -----------------------------------
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app

COPY --from=build /app/publish .

EXPOSE 5132

ENV ASPNETCORE_URLS=http://0.0.0.0:5132

ENTRYPOINT ["dotnet", "ExpenseTracker.dll"]

