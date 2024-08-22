# Route MVC 3-Tire Architecture

## Description
This project is an Employee Management System built using ASP.NET Core MVC. It allows for the management of employees and their respective departments. The application supports all CRUD (Create, Read, Update, Delete) operations for both employees and departments. The project follows a three-tier architecture and implements the Repository pattern and Unit of Work.

## Technologies Used
- ASP.NET Core MVC
- Entity Framework Core
- SQL Server
- Dependency Injection
- Repository Pattern
- Unit of Work Pattern
- Identity (Authentication & Authorization)

## Architecture
The project is structured into three layers:
1. **Presentation Layer**: This layer contains the ASP.NET Core MVC application, including controllers, views, and view models.
2. **Business Logic Layer**: This layer contains the business logic of the application, including services and business rules.
3. **Data Access Layer**: This layer contains the data access logic, including repositories and the Entity Framework Core context.

## Features
- **Employee Management**: Create, read, update, and delete employee records.
- **Department Management**: Create, read, update, and delete department records.
- **Repository Pattern**: Abstracts the data access logic and provides a flexible way to manage data operations.
- **Unit of Work Pattern**: Manages transactions and ensures that a group of operations either all succeed or all fail.

## Getting Started
### Prerequisites
- .NET Core SDK
- SQL Server

### Installation
1. Clone the repository:
   ```bash
   git clone https://github.com/iHebaMohammed/route-mvc-task.git
2. Navigate to the project directory:
      ```bash
   cd route-mvc-task
3. Restore the dependencies:
      ```bash
   dotnet restore
4. Update the database connection string in ''appsettings.json'':
      ```bash
   "ConnectionStrings": {
   "DefaultConnection": "Server=your_server;Database=MVCDbContextRoute;Trusted_Connection=True;"
   }
5. Apply the migrations to create the database:
     ```bash
     dotnet ef database update
### Running the Application
1. Run the application:
   ```bash
   dotnet run
2. Open a browser and navigate to https://localhost:5001 to access the application.
