````markdown
# 🧾 InventoryApp

A simple yet complete ASP.NET Core MVC web application for managing products, orders, and users.  
This project demonstrates **role-based authentication**, **Entity Framework Core integration**, and **basic CRUD operations** for both Admin and User roles.

---

## 🚀 Features

### 👨‍💼 Admin Panel
- Login as admin (`admin@example.com / admin123`)
- Manage products (Add, Edit, Delete)
- View and manage all orders
- Monitor total sales and users

### 🙍‍♂️ User Panel
- Register and login as a normal user
- Browse and order products
- View order history and details
- Secure session-based authentication

---

## 🏗️ Tech Stack

- **Frontend:** Razor Pages (HTML, CSS, Bootstrap)
- **Backend:** ASP.NET Core MVC (.NET 8)
- **Database:** Microsoft SQL Server (EF Core Code First)
- **Authentication:** Cookie-based login system
- **ORM:** Entity Framework Core

---

## ⚙️ Setup Instructions

1. **Clone the repository**
   ```bash
   git clone https://github.com/Yameen-21/InventoryApp.git
   cd InventoryApp
````

2. **Open the project** in Visual Studio

3. **Update the connection string**

   * Open `appsettings.json`
   * Replace the SQL connection string under `"DefaultConnection"` with your own

4. **Run EF migrations**

   ```bash
   Add-Migration Initial
   Update-Database
   ```

5. **Run the project**

   * Press `Ctrl + F5` in Visual Studio
   * The app will open in your browser at:
     `https://localhost:xxxx`

---

## 🔑 Admin Login

| Role        | Email                                         | Password |
| ----------- | --------------------------------------------- | -------- |
| Admin       | [admin@example.com](mailto:admin@example.com) | admin123 |
| User (demo) | [user@example.com](mailto:user@example.com)   | user123  |

---

## 📸 Preview

![App Screenshot](https://via.placeholder.com/900x400.png?text=Inventory+App+Dashboard)

---

## 🧠 About the Project

This project was created as a learning and demonstration tool for:

* .NET Core MVC architecture
* Authentication & Authorization
* Database seeding and migrations
* CRUD operations with EF Core
* MVC separation of concerns and clean structure

---

## 🤝 Contributing

If you’d like to improve or extend this project:

1. Fork the repo
2. Create a new branch (`feature/new-feature`)
3. Submit a pull request

---

## 🧑‍💻 Author

**Yameen**
📧 [GitHub Profile](https://github.com/Yameen-21)

---

## 📜 License

This project is open-source and available under the [MIT License](https://opensource.org/licenses/MIT).

```

---

✅ Copy the above block into your `README.md` file → save → commit and push.  
Your GitHub project page will now automatically show this README beautifully formatted.
```
