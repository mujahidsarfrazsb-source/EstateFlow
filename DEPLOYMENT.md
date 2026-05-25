# EstateFlow System Deployment Guide

## Requirements
- Windows 10 or Windows 11
- Visual Studio 2022
- .NET 8 Desktop Development workload
- MySQL Server or XAMPP MySQL

## Database Setup
1. Open phpMyAdmin or MySQL Workbench.
2. Import `SQL/estateflow.sql`.
3. Confirm database name is `estateflow_db`.

## Connection Setup
Open `Database/DbConnection.cs` and update this line if your MySQL password is different:

`server=localhost;port=3306;database=estateflow_db;uid=root;pwd=;SslMode=None;`

## Run Project
1. Open `EstateFlow.sln` in Visual Studio.
2. Restore NuGet packages.
3. Build solution.
4. Run project.

Default login:
- Username: admin
- Password: admin123
