# Tradisign ApiGateway

Part of the Tradisign e-commerce application: one frontend and seven backends.

## Run locally

Requires the .NET 8 SDK.

```powershell
dotnet build .\ApiGateway.sln
dotnet run --project .\ApiGateway.API\ApiGateway.API.csproj
```

Launch profile URLs: https://localhost:5000.

For the complete local system, run start-all-backend.ps1 from the parent Tradisign folder. Stop with stop-all-backend.ps1. Run the frontend separately from tradisign-frontend.

Configure SQL Server, RabbitMQ, Redis and external providers as used by this service. Historical EF migrations remain compatible with existing databases. Review credentials in appsettings before publishing this repository.
