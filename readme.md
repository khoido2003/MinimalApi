# Minimal API With .NET

## Create project

bash 
```
dotnet new webapi -minimal -n MinimalAPI
```

## Isue with the HTTPS
bash
```
dotnet dev-certs https --trust
```

## Add package
bash
```
dotnet add package + name
```
Find more packages at https://www.nuget.org

## Run the project
bash
```
dotnet run
```

## Set secret userId
bash
```
dotnt user-secrets init

dotnet user-secrets set "UserId" "sa"

dotnet user-secrets set "Password" "Khoizpro7@"

dotnet user-secrets remove "Password"

dotnet user-secrets remove "UserId"

```

## Install dotnet-ef
bash 
```
dotnet tool install --global dotnet-ef
```

## Create migration
bash 
``` 
dotnet ef migrations add + migrationName
```

## Remove migration
bash
```
dotnet ef migrations remove
```

## Update DB
bash 
```
dotnet ef database update
```
