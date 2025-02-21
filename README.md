# PasswordGenerator
This is a Windows Forms Application built with C# that generates secure passwords based on user-selected criteria. The user can specify the length and choose to include uppercase letters, lowercase letters, numbers, and special symbols.
## Features 
- Generate random passwords with customizable character sets.
- Supports uppercase, lowercase, numbers, and symbols.
- Uses cryptographically secure ``RandomNumberGenerator`` for stronger passwords.
- Copy the generated password to the clipboard with a single click.
- Simple and user-friendly Windows Forms UI.

## Installation & Usage
Prerequisites
- Windows OS
- .NET Framework (4.7.2 or later)
- Visual Studio (for development)

Steps to Run
1. **Clone or Download** the repository, or download the ``.exe`` file and run it directly
    ```bash
    git clone https://github.com/your-username/PasswordGenerator.git
    cd PasswordGenerator
   ```
  
2. Open the **PasswordGenerator.sln** file in Visual Studio.
3. Click **Start** or press **F5** to run the application.

## How to Use
1. Select the desired password length using the **numeric input field**.
2. Check the boxes for character types you want to include (**uppercase, lowercase, numbers, symbols**).
3. Click **Generate Password**.
4. Click **Copy to Clipboard** to copy the generated password.

## Security Notes
1. This application uses ``RandomNumberGenerator`` instead of the traditional ``Random`` class for better security.
