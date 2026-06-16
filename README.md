# Gym Trainer Management System

A Windows Forms application built with C# and .NET Framework 4.7.2 designed to manage a gym facility.

## Features

- **Role-based Access Control**: Separate interfaces and tailored dashboards for Admins, Owners, Trainers, and Members.
- **Comprehensive User Management**: Dedicated registration and profile modules for Owners, Trainers, and Members.
- **Fitness Management**: Robust functionality to create, update, and manage Workout Plans and Diet Plans for gym members.
- **Custom UI**: Uses custom components (e.g., `Button_WOC`) for an enhanced, modern user interface.
- **Secure Authentication**: Built-in login functionality to ensure proper data isolation based on user roles.

## Directory Structure

Here's an overview of the key files and their purposes in this project:

```text
.
├── AdminInterface.cs        # Admin dashboard and controls
├── OwnerInterface.cs        # Gym owner management dashboard
├── TrainerInterface.cs      # Trainer specific functionality
├── MemberMenu.cs            # Interface for gym members
├── DietPlan.cs              # Diet plan management module
├── WorkoutPlan.cs           # Workout routine management
├── Login.cs                 # System authentication
├── Register.cs              # General user registration
├── MemberRegister.cs        # Member registration specific
├── TrainerRegister.cs       # Trainer registration specific
├── OwnerRegister.cs         # Owner registration specific
├── Button_WOC.cs            # Custom UI button component
├── Properties/              # Assembly information and resources
├── DB.csproj                # Main C# project file
└── Program.cs               # Application entry point
```

*(Note: `.resx` files accompany most `.cs` files and store the visual layout data for the forms, and `Designer.cs` files contain auto-generated UI code).*

## Technologies Used

- C#
- .NET Framework 4.7.2
- Windows Forms (WinForms)

## Setup Instructions

1. **Clone the repository:**
   ```bash
   git clone <your-github-repo-url>
   ```
2. **Open the Project in Visual Studio:**
   - Open Visual Studio.
   - Go to **File** > **Open** > **Project/Solution**.
   - Navigate to the cloned directory and select the `DB.csproj` file.
3. **Restore Dependencies:**
   - Right-click the solution in the Solution Explorer and select **Build Solution** (this will automatically restore necessary dependencies).
4. **Run the Application:**
   - Ensure `Program.cs` is set as the startup object.
   - Press `F5` or click the **Start** button at the top to compile and launch the application.
