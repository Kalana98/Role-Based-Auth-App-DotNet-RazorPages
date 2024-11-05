# AuthWebApp

AuthWebApp is a role-based authentication web application built with .NET Identity, using a .NET backend and Razor Pages for the frontend. The application allows users to register, log in, and access role-specific features depending on their assigned roles (Admin, Client, or Seller).

## Table of Contents
- [Features](#features)
- [Project Structure](#project-structure)
- [Installation](#installation)
- [Usage](#usage)
- [Screenshots](#screenshots)
- [Contributing](#contributing)
- [License](#license)

## Features
- Role-based authentication with ASP.NET Identity
- User roles: Admin, Client, and Seller
- Dynamic navigation bar with role-specific options
- Secure login and registration system

## Project Structure
- **Areas/Identity**: Contains ASP.NET Identity pages like Login, Register, and Logout.
- **Data/ApplicationDbContext.cs**: The Entity Framework Core database context for the project.
- **Models/ApplicationUser.cs**: Extends the default Identity user model, allowing for additional properties.
- **Pages**: Razor Pages for shared views and role-specific pages.

## Installation
1. **Clone the repository**:
    ```bash
    git clone https://github.com/your-username/AuthWebApp.git
    cd AuthWebApp
    ```

2. **Set up the database**:
    - Open `ApplicationDbContext.cs` and configure your database connection.
    - Run the migrations:
      ```bash
      dotnet ef database update
      ```

3. **Run the application**:
    ```bash
    dotnet run
    ```

## Usage
1. **Register a new user**: Go to the registration page to create a new account.
2. **Assign roles**: Assign roles (Admin, Client, Seller) to users in the database (e.g., using the `AspNetUserRoles` table).
3. **Login**: Log in with your credentials to access role-specific navigation and pages.

### Role-Based Navigation
- **Admin**: Can view the profile and logout options in the "Admin" dropdown.
- **Client**: Has access to "Client" dropdown with profile and logout options.
- **Seller**: Accesses the "Seller" dropdown with profile and logout options.
- **Unauthenticated Users**: See the "Register" and "Login" links in the navigation bar.

## Screenshots
### Image 1
![Screenshot 2024-11-05 202051](https://github.com/user-attachments/assets/5d6c306a-3938-446f-9126-d477894e6152)

### Image 2
![Screenshot 2024-11-05 202101](https://github.com/user-attachments/assets/06a6af7e-f4d9-4af7-a767-05253df4b281)

### Image 3
![Screenshot 2024-11-05 202127](https://github.com/user-attachments/assets/c8e4ff9f-d10f-475f-af5f-e417713b14ba)

### Image 4
![Screenshot 2024-11-05 202138](https://github.com/user-attachments/assets/3d45e66a-a8f5-4e15-bc1a-648e01a7e320)

## Contributing
Contributions are welcome! Please feel free to submit a Pull Request or open an Issue.

## License
This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.
