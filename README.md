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

ASP.NET Core MVC	

Entity Framework Core	

SQL Server

ASP.NET Identity	

Bootstrap



🧪 Testing & Validation
Role-based access tested via controller and action-level restrictions

Unauthorized users redirected to custom "Access Denied" page

Role seeding verified on application startup
