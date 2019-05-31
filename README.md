# PAL .NET Tracker

Running

```bash
dotnet run --project src/PalTracker
```

Binds on `localhost:5000` (http) and `localhost:5001` (https)

Releasing

```bash
dotnet publish src/PalTracker --configuration Release
```

Publish to CF

```bash
cf push pal-tracker --random-route -p src/PalTracker/bin/Release/netcoreapp2.1/publish
```