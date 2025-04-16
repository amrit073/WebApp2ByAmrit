# WebApp2ByAmrit

This is an ASP.NET Core MVC project that demonstrates various features including Razor views, model validation, and form handling.

## Project Setup Instructions

### Prerequisites
- .NET 6.0 SDK or later
- Visual Studio 2022 or Visual Studio Code

### Setup Steps

1. **Clone the repository**
   ```
   git clone https://github.com/yourusername/WebApp2ByAmrit.git
   cd WebApp2ByAmrit
   ```

2. **Build the project**
   ```
   dotnet build
   ```

3. **Run the application**
   ```
   dotnet run
   ```

4. **Access the application**
   Open your browser and navigate to:
   ```
   https://localhost:7001
   ```
   or
   ```
   http://localhost:5001
   ```
   (The exact port numbers may vary)

### Features

- **MyRazorPage**: Displays current date and time, personal information, and a multiplication table
- **Create Student Record**: A form to create a new student record with validation
- **Student Details**: Displays the details of a created student

### Form Validation

The application includes both client-side and server-side validation for the student form. Required fields are marked, and appropriate error messages are displayed when validation fails.

### Technologies Used

- ASP.NET Core 6.0
- MVC Architecture
- Razor Views
- Entity Framework Core (In-memory database)
- Bootstrap for styling 