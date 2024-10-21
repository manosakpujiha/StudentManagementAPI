# Student Management API

## Overview

The Student Management API is a web application built with ASP.NET Core that provides JWT-based authentication and authorization. It includes a sample endpoint to demonstrate the functionality of the API.

## Features

- JWT Authentication and Authorization
- Swagger/OpenAPI support for API documentation
- HTTPS redirection


## Getting Started

### Prerequisites

- [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- [Visual Studio Code](https://code.visualstudio.com/) or any other IDE

### Installation

1. Clone the repository:
    ```bash
    git clone https://github.com/manosakujiha/StudentManagementAPI.git
    cd StudentManagementAPI
    ```

2. Restore the dependencies:
    ```bash
    dotnet restore
    ```

### Running the Application

1. Build the project:
    ```bash
    dotnet build
    ```

2. Run the project:
    ```bash
    dotnet run --project StudentManagement.API
    ```

3. Open your browser and navigate to `https://localhost:5001/swagger` to view the Swagger UI.

## Endpoints



### JWT Authentication

The API uses JWT Bearer tokens for authentication. You need to include a valid JWT token in the `Authorization` header of your requests to access protected endpoints.

## Configuration

### JWT Settings

The JWT settings are configured in the `Program.cs` file. Update the `ValidIssuer`, `ValidAudience`, and `IssuerSigningKey` with your actual values.

```csharp
options.TokenValidationParameters = new TokenValidationParameters
{
    ValidateIssuer = true,
    ValidateAudience = true,
    ValidateLifetime = true,
    ValidateIssuerSigningKey = true,
    ValidIssuer = "StudentManagementAPI",
    ValidAudience = "StudentManagementAPIAudience",
    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("supersecretkey1234567890!@#$%^"))
};