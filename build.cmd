dotnet restore
dotnet tool install -g Amazon.Lambda.Tools --framework netcoreapp3.1
dotnet lambda package --configuration Release --framework netcoreapp3.1 --project-location src/Worker --output-package output/worker/Release/netcoreapp3.1/worker.zip
