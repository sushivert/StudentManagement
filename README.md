# Student Management System

A simple student management web app built with ASP.NET Core MVC and an Entity Framework Core in-memory database.

## Features
- View a list of students
- Add a student with form validation
- PRG (Post/Redirect/Get) pattern after saving

## How to run
1. Install the [.NET SDK](https://dotnet.microsoft.com/download)
2. Clone this repo:
```
   git clone https://github.com/sushivert/StudentManagement.git
```
3. Go into the project folder and run it:
```
   cd StudentManagement/studentManagement
   dotnet run
```
4. Open the address shown in the terminal (for example `http://localhost:5138`)

## Note
Data is stored in memory, so it resets every time the app restarts.