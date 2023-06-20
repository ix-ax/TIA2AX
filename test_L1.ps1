# run build

dotnet run --project cake/Build.csproj --do-test false --do-pack false
exit $LASTEXITCODE;