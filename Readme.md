# Student Management API

## Overview

The **Student Management API** is a web application designed to manage student data, including adding, updating, deleting, and viewing student records. The app includes a simple front-end interface that interacts with a back-end **ASP.NET Core API**, allowing users to manage students through a user-friendly interface. It also provides JWT-based authentication and authorization.

The project is deployed on **Microsoft Azure** and supports operations like fetching all students, adding new students, editing existing students, and deleting student records.

## Features

- **Add a New Student**: Input fields to add student details (first name, last name, email) and save them to the database.
- **View All Students**: Display a list of all students with their details, such as ID, first name, last name, and email.
- **Update Student Information**: Modify the information of an existing student.
- **Delete a Student**: Remove a student record from the database using a delete button.
- **Responsive Front-end**: Simple HTML-based user interface that communicates with the back-end API.
- JWT Authentication and Authorization
- Swagger/OpenAPI support for API documentation
- HTTPS redirection



## Technologies Used

### Back-End (API):
- **ASP.NET Core 6.0**: The core back-end framework used to create the API for managing students.
- **Entity Framework Core**: ORM (Object-Relational Mapping) for database operations.
- **SQLite**: The database used for storing student records.
- **Microsoft Azure**: Hosting platform for the deployed API and front-end.
- **Swagger**: API documentation and testing tool for interacting with the API endpoints.

### Front-End:
- **HTML5 & CSS3**: Used for structuring and styling the web page.
- **JavaScript (Vanilla)**: Used to make API calls (fetch, post, delete) to the back-end API and dynamically update the page content.
  
### Tools:
- **Azure App Service**: Used to deploy the API and host the front-end.
- **Postman**: API testing tool (recommended for testing POST, DELETE, and PUT requests).
- **cURL**: Command-line tool for testing API requests (alternative to Postman).

## API Endpoints

### Base URL: 
- `https://studentapi.azurewebsites.net`

### API Routes:
1. **GET** `/api/Students/GetAllStudents`  
   - Fetches all students from the database.

2. **GET** `/api/Students/GetStudentById/{id}`  
   - Fetches a student by their ID.

3. **POST** `/api/Students/AddStudent`  
   - Adds a new student. Requires a request body with student details (firstName, lastName, email).

4. **PUT** `/api/Students/{id}`  
   - Updates an existing student's details by their ID.

5. **DELETE** `/api/Students/RemoveStudent/{id}`  
   - Deletes a student by their ID.

## Project Setup

### Prerequisites
1. **.NET 8.0 SDK**: Ensure that you have .NET 8.0 installed on your local machine. [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
2. **SQLite**: The project uses SQLite for data storage, and the database is already configured.
3. **Azure Account**: For deployment, an Azure account is required (optional for local testing).
4. - [Visual Studio Code](https://code.visualstudio.com/) or any other IDE

### Local Setup Instructions

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

3. Open your browser and navigate to `https://localhost:5091/swagger` to view the Swagger UI.


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


Front-End Setup
Serve the Front-End: Open the index.html file located in the wwwroot folder. The JavaScript in the file is configured to communicate with the API endpoints.

Test the Application: Use the API routes listed above with tools like Postman or directly in the browser for GET requests to test the API.

Deployment on Microsoft Azure
The project is deployed on Azure App Service using the F1 Free Tier. To redeploy the project to Azure, follow these steps:

Log in to Azure CLI:

bash
Copy code
az login
Deploy the Web App:

bash
Copy code
az webapp up --name studentmanagementapptwo --resource-group StudentResourceGroup --plan MyAppPlan --sku F1 --runtime "dotnet|6.0"
Access the Deployed Application:

API: https://studentmanagementapptwo.azurewebsites.net
Swagger UI (if enabled): https://studentmanagementapptwo.azurewebsites.net/swagger
Testing the API
Using Swagger:
If Swagger is enabled, you can test the endpoints interactively by going to the /swagger URL:

arduino
Copy code
https://studentmanagementapptwo.azurewebsites.net/swagger
Using Postman:
You can use Postman to test the API by sending requests to the API routes.

Using Browser for GET Requests:
Access the GET endpoints directly in your browser by navigating to:

ruby
Copy code
https://studentmanagementapptwo.azurewebsites.net/api/Students/GetAllStudents
Troubleshooting
404 Error: Ensure the correct URL is used. The base URL should be https://studentmanagementapptwo.azurewebsites.net.
500 Error: Check logs in Azure or locally using dotnet run to inspect the error message.
License
This project is licensed under the MIT License - see the LICENSE file for details.