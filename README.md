# 🛒 Sales & Purchases Management System – ASP.NET MVC

This project is a **production-oriented CRUD web application** built with **C#**, **ASP.NET MVC**, **.NET 5.0**, and **Entity Framework Core**. It demonstrates solid experience with **enterprise web development**, applying clean architecture principles, separation of concerns, and maintainable code practices.

---

## 🚀 Tech Stack

* **C# / .NET 5.0**
* **ASP.NET MVC**
* **Entity Framework Core** (Code First & Migrations)
* **SQL Server**
* **Razor Views**
* **Bootstrap** (responsive UI)

---

## 🎯 Project Purpose

This project was designed to showcase **mid-level to senior-level skills** in .NET web development, including:

* Implementation of **CRUD operations** following MVC best practices
* Data persistence and abstraction using **Entity Framework Core**
* Clear separation between **Controllers, Services, Models, and Data Access**
* Scalable structure ready for future enhancements

---

## ⚙️ Key Features

* Product management (Create, Read, Update, Delete)
* Sales registration
* Purchase registration
* Relational database integration
* Server-side validation and data consistency

---

## ▶️ Running the Project Locally

### Prerequisites

* .NET SDK 5.0
* Visual Studio 2019 or 2022
* SQL Server (LocalDB or standalone instance)
* Git

---

### Clone the Repository

```bash
git clone https://github.com/your-username/your-repository.git
cd your-repository
```

---

### Database Configuration

Update the connection string in `appsettings.json`:

```json
"ConnectionStrings": {
  "DefaultConnection": "Server=localhost;Database=SalesManagementDb;Trusted_Connection=True;"
}
```

---

### Apply Database Migrations

```bash
dotnet ef database update
```

---

### Run the Application

```bash
dotnet run
```

Or simply run the project using **F5** in Visual Studio.

The application will be available at:

```
https://localhost:5001
```

---

## 🧠 Engineering Highlights

* MVC architectural pattern
* Entity Framework Core with migrations
* Clean and readable codebase
* Easily extensible for authentication, authorization, and reporting

---

## 👨‍💻 Author

Developed by **Keven Grillo** 🚀
