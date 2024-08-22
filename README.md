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


### Authentication using identity
![Screenshot (170)](https://github.com/user-attachments/assets/41de55f4-7099-45b8-9860-f40f7048bb83)
![Screenshot (171)](https://github.com/user-attachments/assets/1fac1e09-9fee-40b7-aec4-836c3a04c86d)

### CRUDs operation of Department
![Screenshot (176)](https://github.com/user-attachments/assets/49c0bc6e-77a0-4dd3-a10e-f7b1390653ba)
![Screenshot (175)](https://github.com/user-attachments/assets/6f5ee193-8451-4ce4-aceb-b241e693ab19)
![Screenshot (174)](https://github.com/user-attachments/assets/2cdeda12-8ceb-47de-a517-7254b8807735)
![Screenshot (173)](https://github.com/user-attachments/assets/b98d4cae-48cd-428f-aa79-b20081e5e60a)
![Screenshot (177)](https://github.com/user-attachments/assets/aad614f7-3755-44f2-be82-7d63c7ed274d)

### CRUDs operation of Employee
![Screenshot (182)](https://github.com/user-attachments/assets/2ad29518-1861-4a2f-a68a-61a0d76482ae)
![Screenshot (181)](https://github.com/user-attachments/assets/9b739ea7-8d66-4663-be9e-deaefe2c2ee4)
![Screenshot (180)](https://github.com/user-attachments/assets/0d87ef48-1fdc-4670-92a4-ec4fa6a4aa92)
![Screenshot (179)](https://github.com/user-attachments/assets/24885dc8-1146-4ec5-a286-f968d5f991f0)
![Screenshot (178)](https://github.com/user-attachments/assets/47545d74-ef56-48f9-93e8-7244a1fddee0)

### CRUDs operation of User 'ApplicationUser:IdentityUser'
![Screenshot (187)](https://github.com/user-attachments/assets/a4bc4b45-face-4563-8a50-7b056c7f25e7)
![Screenshot (186)](https://github.com/user-attachments/assets/e565fbb4-d4e2-4b85-915b-d69ba431d918)
![Screenshot (185)](https://github.com/user-attachments/assets/5475a193-05eb-4852-8c6d-350699aafff8)
![Screenshot (184)](https://github.com/user-attachments/assets/749d0bf2-dc68-49c8-b54d-fb5b24f148cf)

### Roles in system
![Screenshot (188)](https://github.com/user-attachments/assets/22bbe5d3-5747-43e7-ad7a-0d3b01368d4d)

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

## Project Structure
#### Controllers:
Contains the MVC controllers for handling HTTP requests.
#### Views:
Contains the Razor views for rendering the UI.
#### Models: 
Contains the data models for employees and departments.
#### Repositories:
Contains the repository classes for data access.
#### Services: 
Contains the business logic services.
#### UnitOfWork: 
Contains the Unit of Work implementation.
## Contributing
Contributions are welcome! Please fork the repository and submit a pull request.
