# 🧩 MiniProductsApi

A clean and simple ASP.NET Core 8 REST API built as part of my backend learning roadmap.

This project demonstrates how to build RESTful endpoints, implement a service layer, and expose CRUD operations with Swagger UI.

## 🚀 Features

✔️ ASP.NET Core 8 Web API  
✔️ Layered architecture  
- Models  
- Services (Business Logic)  
- Controllers (API Endpoints)  

✔️ CRUD operations (Create, Read, Update, Delete)  
✔️ In-Memory data storage (no database required)  
✔️ Swagger UI & API documentation enabled by default  
✔️ Clean, beginner-friendly codebase  

## 📂 Project Structure
```
MiniProductsApi/
 ├── Controllers/
 │    └── ProductsController.cs
 ├── Models/
 │    └── Product.cs
 ├── Services/
 │    └── ProductService.cs
 ├── Program.cs
 ├── MiniProductsApi.csproj
 ├── README.md
 └── LICENSE
```

## 📦 Technologies Used

- .NET 8
- ASP.NET Core Web API
- C#
- Swagger (Swashbuckle) for API documentation

## 🔗 API Endpoints

| Method | Endpoint              | Description                  |
|--------|-----------------------|------------------------------|
| GET    | /api/products         | Get all products             |
| GET    | /api/products/{id}    | Get product by ID            |
| POST   | /api/products         | Create a new product         |
| PUT    | /api/products/{id}    | Update an existing product   |
| DELETE | /api/products/{id}    | Delete a product             |

## ▶️ Running the Project

### 1️⃣ Restore dependencies
```bash
dotnet restore
```

### 2️⃣ Run the API
```bash
dotnet run
```

### 3️⃣ Open Swagger UI
The API documentation will be available at:

👉 **http://localhost:5000/swagger**

(or whichever port your local environment uses)

## 📘 Example Product Object
```json
{
  "id": 1,
  "name": "Laptop",
  "price": 55000
}
```

## 🛠 Future Enhancements

- Add SQL Server or PostgreSQL database
- Add Entity Framework Core
- Implement Authentication (JWT)
- Add DTOs and FluentValidation
- Add Unit Tests

## 📜 License

This project is licensed under the MIT License.

See the [LICENSE](LICENSE) file for details.

## ⭐ Support the Project

If you find this helpful, please ⭐ star the repository!