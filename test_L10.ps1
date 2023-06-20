# run build

dotnet run --project cake/Build.csproj --do-test true --do-pack false
exit $LASTEXITCODE;