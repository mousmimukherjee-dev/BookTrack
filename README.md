# BookVault

BookVault is a full-stack book management application built using Angular 20 and .NET 9, deployed to Microsoft Azure.

The application allows users to register and log in, manage their books, and save personal quotes. The project includes JWT authentication, SQL Server with Entity Framework Core, and a responsive UI.

## Live Demo

**Frontend:**  
https://brave-stone-058ce9710.5.azurestaticapps.net

**Backend / Scalar API:**  
https://bookvault-api-mousumi-byaaafaee0emh6a2.swedencentral-01.azurewebsites.net/scalar/v1#description/introduction

**GitHub:**  
https://github.com/mousmimukherjee-dev/BookVault

---

## Features

### Authentication
- User registration
- User login with email and password
- JWT-based authentication

### Book Management
- View books
- Add new book
- Delete book
- Edit book (in progress)

### My Quotes
- View saved quotes
- Add quotes
- Delete quotes
- Quotes are connected to the logged-in user

### UI
- Responsive design using Bootstrap
- Dark theme
- Navigation between Books and My Quotes
- Font Awesome icons

---

## Tech Stack

### Frontend
- Angular 20
- TypeScript
- Bootstrap
- Font Awesome
- RxJS

### Backend
- C#
- .NET 9
- ASP.NET Core Web API
- Entity Framework Core
- JWT Authentication
- ASP.NET Core Identity
- Scalar / OpenAPI

### Database
- Microsoft SQL Server
- Azure SQL Database

### Tools & Deployment
- Visual Studio
- Visual Studio Code
- GitHub
- Azure App Service
- Azure Static Web Apps
- Azure SQL

---

## Application Structure

```
BookVault
│
├── backend
│   └── BookVaultApi
│       └── BookVaultApi
│           ├── Controllers
│           ├── Data
│           ├── Models
│           ├── Services
│           ├── Program.cs
│           └── appsettings.json
│
├── frontend
│   └── BookVault
│       ├── src
│       │   └── app
│       │       ├── components
│       │       ├── services
│       │       └── interceptors
│       └── angular.json
│
└── README.md
```