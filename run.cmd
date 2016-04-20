@echo off
dotnet restore --infer-runtimes

dotnet publish dispatch/project.json -o bin -f netcoreapp1.0
dotnet publish reflect/project.json -o bin -f netcoreapp1.0

cd bin
dispatch.exe