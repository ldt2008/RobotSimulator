# Robot Simulator

The application is a simulation of a toy robot moving on a square tabletop, of dimensions 5 units x 5 units.

## Introduction

This project was created as a learning exercise to demonstrate the basic features of C# and .NET Core.

```
|-- RobotSimulator
|   |-- RobotSimulator
|   |   |--Programme.cs
|   |   |--Robot.cs
|   |-- RobotSimulator.Test
|   |   |--RobotSimulatorTest.cs
|   |-- Commands.txt
|   |-- README.md
```

- RobotSimulator: Project folder with two classes Programme.cs and Robot.cs
- RobotSimulator.Test: Unit testing project folder
- Commands.txt: Text file contain the commands
- README.md: Instruction file

## Installation

You can clone this repository or download the source code as a ZIP file.

### Install .Net Core Framework
To run this project, you need to have [.NET Core 7.0 SDK](https://dotnet.microsoft.com/download) installed on your machine.

### Run Console applicatiom and Unit testing

Go to folder RobotSimulator and run command below to start Console Application
```Bash
dotnet run
```
Run command below to execute Unit testing
```Bash
dotnet test
```

### Debug with Visual Studio Code

To debug the application with Visual Studio Code, you need to do the following:

- Create a folder named .vscode
- Create a file named launch.json inside the folder
- Copy and paste the content below into the file

```json
{
    "version": "0.2.0",
    "configurations": [
        {
            "name": ".NET Core Launch (console)",
            "type": "coreclr",
            "request": "launch",
            "preLaunchTask": "build",
            "program": "${workspaceFolder}/RobotSimulator/bin/Debug/net7.0/RobotSimulator.dll",
            "args": [],
            "cwd": "${workspaceFolder}/RobotSimulator",
            "console": "integratedTerminal",
            "stopAtEntry": false
        }
    ]
}
```
### Usage

To use the application, follow these steps:

- Enter a command from the list of suggestions, you can find the example command in the Comnands.txt.
- Type REPORT to show the position of the robot.

```Bash
--------------------------------------------------
Robot Simulator Console Application
--------------------------------------------------
Enter a command (PLACE X,Y,F/MOVE/LEFT/RIGHT/REPORT)
Command: PLACE 0,0,NORTH
```




