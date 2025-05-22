### This is a simple order management system

## Necessary things to be installed before use:
# .net SDK ( minimum v-8.0.100+ )
 - check if installed with cmd: dotnet --version
# EF core tools:
 - cmd: dotnet tool install --global dotnet-ef
 - verify by cmd: dotnet ef --version

# Features:
 - Clean Architecture (Domain, Application, Infrastructure, API)
 - Entity Framework Core (SQLite)
 - Full CRUD Operation
 - Swagger UI for testing

## To get started:
# Clone the Repository:
 - git clone https://github.com/BygidHasan/OrderManagementSystem.git
 - cd OrderManagementSystem

# Build and Run:
 - dotnet build
 - dotnet run --project OrderManagement.API

# The project will run in:
 - http://localhost:5217
# Go to swagger to test the APIs:
 - http://localhost:5217/swagger
