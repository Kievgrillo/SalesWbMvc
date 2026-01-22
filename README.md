# 🛒 Sales & Purchases System – ASP.NET MVC

This project is a **CRUD web application** developed in **C#** using **ASP.NET MVC**, **.NET 5.0**, and **Entity Framework Core**. The system manages **product sales and purchases**, following the MVC architectural pattern and clean code practices.

---

## 🚀 Technologies

* C#
* .NET 5.0
* ASP.NET MVC
* Entity Framework Core
* SQL Server
* Razor Views

---

## 🎯 Project Overview

The goal of this project is to demonstrate:

* CRUD operations (Create, Read, Update, Delete)
* Database persistence with Entity Framework Core
* MVC architecture organization
* A maintainable and scalable web application

---

## ⚙️ Main Features

* Product registration
* Product listing
* Product editing
* Product deletion
* Sales records
* Purchase records

---

## ▶️ How to Run the Project Locally

### Prerequisites

* .NET SDK 5.0
* Visual Studio 2019 or 2022
* SQL Server (LocalDB or configured instance)
* Git

---

### Clone the Repository

```bash
git clone https://github.com/your-username/your-repository.git
cd your-repository
```

---

### Configure the Database

Update the connection string in `appsettings.json`:

```json
"ConnectionStrings": {
  "DefaultConnection": "Server=localhost;Database=SalesSystemDb;Trusted_Connection=True;"
}
```

---

### Apply Migrations

```bash
dotnet ef database update
```

---

### Run the Application

```bash
dotnet run
```

Or press **F5** in Visual Studio.

The application will be available at:

```
https://localhost:5001
```

---

## 👨‍💻 Author

Developed by **Keven Grillo** 🚀
