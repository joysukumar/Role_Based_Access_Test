🔐 Project Title: Role-Based Authentication & Authorization System in ASP.NET Core MVC

🧩 Description

This project demonstrates a secure and scalable implementation of role-based authentication and authorization using ASP.NET Core MVC and Identity Framework. It enables user registration, login, and access control based on predefined roles such as Admin, Manager, and User.

🚀 Key Features

User Registration & Login with secure password hashing

Role Management using IdentityRole and RoleManager

Access Control via [Authorize(Roles = "RoleName")] attributes

Custom Access Denied Page for unauthorized access attempts

Initial Role Seeding and default admin creation

Secure Password Policies (uppercase, lowercase, number, special character)

Bootstrap UI Integration for clean and responsive design

🛠️ Technologies Used
Technology	Purpose
ASP.NET Core MVC	Web application framework
Entity Framework Core	ORM for database operations
SQL Server	Relational database
ASP.NET Identity	Authentication & role-based authorization
Bootstrap	UI styling
📁 Folder Structure Highlights
Controllers/ – Role-protected endpoints

Models/ – User and role entities

Views/ – Razor views with conditional UI rendering

Data/ – DbContext and Identity configuration

Program.cs – Role seeding and middleware setup

🔒 Authorization Examples
csharp
[Authorize(Roles = "Admin")]
public class AdminController : Controller
{
    public IActionResult Dashboard() => View();
}

[Authorize(Roles = "Admin,Manager")]
public IActionResult ManageUsers() => View();
🧪 Testing & Validation
Role-based access tested via controller and action-level restrictions

Unauthorized users redirected to custom "Access Denied" page

Role seeding verified on application startup
