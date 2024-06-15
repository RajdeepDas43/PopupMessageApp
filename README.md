# PopupMessageApp

## Introduction

The Popup Message App is a simple Windows Forms application developed in Visual Basic using the .NET framework. When the application is launched, it displays a popup message with detailed information. This example demonstrates basic Windows Forms functionality in Visual Basic.

## Prerequisites

- .NET SDK 8.0 or later
- Visual Studio Code
- C# extension for Visual Studio Code

## Project Structure

```
PopupMessageApp/
├── PopupMessageApp.vbproj
└── Form1.vb
```

### `PopupMessageApp.vbproj`

This file defines the project configuration and dependencies. It specifies the use of the Windows Desktop SDK and targets the .NET 8.0 framework.

### `Form1.vb`

This file contains the main code for the application. It defines a Windows Form that displays a popup message when loaded.

## Setup Instructions

1. **Install .NET SDK**:
   - Download and install the .NET SDK from the [.NET download page](https://dotnet.microsoft.com/download).

2. **Install Visual Studio Code**:
   - Download and install Visual Studio Code from the [VS Code download page](https://code.visualstudio.com/Download).

3. **Install C# Extension in Visual Studio Code**:
   - Open Visual Studio Code.
   - Go to Extensions view by clicking the Extensions icon in the Activity Bar on the side of the window or by pressing `Ctrl+Shift+X`.
   - Search for "C#" and install the extension authored by Microsoft.

## Building and Running the Application

1. **Open a terminal** in Visual Studio Code.

2. **Navigate to the project directory**:
   ```sh
   cd path/to/PopupMessageApp
   ```

3. **Clean the project**:
   ```sh
   dotnet clean
   ```

4. **Build the project**:
   ```sh
   dotnet build
   ```

5. **Run the project**:
   ```sh
   dotnet run
   ```

When you run the application, you should see a popup message with detailed information.

## Code Explanation

### `PopupMessageApp.vbproj`

```xml
<Project Sdk="Microsoft.NET.Sdk.WindowsDesktop">
  <PropertyGroup>
    <OutputType>WinExe</OutputType>
    <TargetFramework>net8.0-windows</TargetFramework>
    <UseWindowsForms>true</UseWindowsForms>
    <RootNamespace>PopupMessageApp</RootNamespace>
  </PropertyGroup>
</Project>
```

- **Sdk**: Specifies the SDK to use, which is `Microsoft.NET.Sdk.WindowsDesktop` for Windows Forms applications.
- **OutputType**: Defines the output type as a Windows executable (`WinExe`).
- **TargetFramework**: Sets the target framework to .NET 8.0.
- **UseWindowsForms**: Enables Windows Forms for the project.
- **RootNamespace**: Sets the root namespace for the project.

### `Form1.vb`

```vb
Imports System.Windows.Forms

Public Class Form1
    Inherits Form

    Public Sub New()
        Me.Text = "Popup Message App"
        AddHandler Me.Load, AddressOf Me.Form1_Load
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs)
        ' Display a detailed popup message when the form loads
        Dim message As String = "Welcome to the Popup Message App!" & vbCrLf & vbCrLf &
                                "This application demonstrates how to display a message box in Visual Basic." & vbCrLf &
                                "You can customize the content, title, buttons, and icon of the message box." & vbCrLf &
                                "Click 'OK' to continue or 'Cancel' to exit."

        Dim title As String = "Detailed Popup Message"
        Dim buttons As MessageBoxButtons = MessageBoxButtons.OKCancel
        Dim icon As MessageBoxIcon = MessageBoxIcon.Information

        Dim result As DialogResult = MessageBox.Show(message, title, buttons, icon)

        If result = DialogResult.Cancel Then
            ' Close the application if the user clicks 'Cancel'
            Me.Close()
        End If
    End Sub

    <STAThread>
    Public Shared Sub Main()
        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)
        Application.Run(New Form1())
    End Sub
End Class
```

- **Imports System.Windows.Forms**: Imports the Windows Forms namespace to use its classes and methods.
- **Form1 Class**: Inherits from the `Form` class to create a new Windows Form.
  - **Constructor (`Sub New`)**: Sets the form's title and attaches an event handler to the form's `Load` event.
  - **Form1_Load**: Event handler that displays a detailed popup message when the form loads.
    - **MessageBox.Show**: Displays a message box with the specified message, title, buttons, and icon.
    - **DialogResult**: Captures the result of the message box (which button was clicked).
    - **If result = DialogResult.Cancel**: Closes the form if the "Cancel" button is clicked.
- **Main Method**: Entry point of the application.
  - **Application.EnableVisualStyles**: Enables visual styles for the application.
  - **Application.SetCompatibleTextRenderingDefault**: Sets the default rendering mode.
  - **Application.Run(New Form1())**: Runs the form.

This project serves as a simple example to demonstrate how to create a Windows Forms application in Visual Basic that displays a popup message. You can extend this example by adding more features and functionality as needed.
