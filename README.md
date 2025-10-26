# 🧾 InventoryApp

A modern and complete **ASP.NET Core MVC** web application for managing products, orders, and users.  
It showcases **role-based authentication**, **Entity Framework Core**, and **CRUD operations** for both Admin and User roles — designed to demonstrate full-stack development skills with clean architecture and responsive UI.

---

## 🚀 Features

### 👨‍💼 Admin Panel
- Secure admin login (`admin@example.com / admin123`)
- Manage products (Add, Edit, Delete)
- View and manage all user orders
- Monitor total sales and registered users

### 🙍‍♂️ User Panel
- User registration and login
- Browse products and place orders
- View detailed order history
- Protected routes with session-based authentication

---

## 🏗️ Tech Stack

- **Frontend:** Razor Pages, HTML5, CSS3, Bootstrap 5  
- **Backend:** ASP.NET Core MVC (.NET 8)  
- **Database:** Microsoft SQL Server (Code First with EF Core)  
- **Authentication:** Cookie-based user sessions  
- **ORM:** Entity Framework Core  

---

## ⚙️ Setup Instructions

1. **Clone the repository**
   ```bash
   git clone https://github.com/Yameen-21/InventoryApp.git
   cd InventoryApp
   ```

2. **Open the project** in Visual Studio

3. **Update your database connection**
   - Open `appsettings.json`
   - Replace `"DefaultConnection"` with your own SQL Server connection string

4. **Run EF migrations**
   ```bash
   Add-Migration Initial
   Update-Database
   ```

5. **Run the project**
   - Press `Ctrl + F5` in Visual Studio  
   - The app will open automatically at `https://localhost:xxxx`

---

## 🔑 Admin Login

| Role        | Email                                         | Password |
| ------------ | --------------------------------------------- | -------- |
| Admin        | [admin@example.com](mailto:admin@example.com) | admin123 |
| User (Demo)  | [user@example.com](mailto:user@example.com)   | user123  |

---

## 🧠 About the Project

InventoryApp was built to demonstrate:
- ASP.NET MVC design patterns  
- Authentication & Authorization flow  
- Database seeding and migrations  
- CRUD operations with EF Core  
- Clean, modular code structure following best practices  

---

## 🤝 Contributing

1. Fork this repository  
2. Create a feature branch (`feature/new-feature`)  
3. Commit your changes and open a pull request  

---

## 🧑‍💻 Author

**Muhammad Yameen**  
📧 [m.yameen.zada@gmail.com](mailto:m.yameen.zada@gmail.com)  
🌐 [GitHub Profile](https://github.com/Yameen-21)

---

© 2025 Muhammad Yameen — All Rights Reserved
