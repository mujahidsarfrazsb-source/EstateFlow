# EstateFlow System

A desktop-based **Real Estate Management System** built with **C# Windows Forms**, **MySQL**, and **ADO.NET-style repository logic**. EstateFlow is designed to manage properties, clients, agents, sales records, authentication, reporting, and day-to-day real estate operations through a structured desktop application.

## Overview

EstateFlow demonstrates a complete CRUD-based real estate workflow with a Windows desktop interface and a relational MySQL database. The project focuses on clean separation between the user interface, application models, database operations, and reporting functionality.

## Key Features

- 🔐 **Authentication & Role Support** — Login system with role-based access.
- 📊 **Dashboard** — Overview statistics for key real estate data.
- 🏠 **Property Management** — Create, read, update, delete, search, and manage property records.
- 👥 **Client Management** — Maintain client information and records.
- 🤝 **Agent Management** — Manage real estate agent profiles and related information.
- 💰 **Sales Management** — Record and manage property sales.
- 🔎 **Search & Filtering** — Find records efficiently through DataGridView-based interfaces.
- 📄 **CSV Reporting** — Export selected data for reporting and analysis.
- 🗄️ **MySQL Database** — Relational database with SQL scripts for setup and migration.
- 📚 **Documentation** — Includes system requirements, technical documentation, user guidance, and viva preparation material.

## Technology Stack

| Technology | Purpose |
|---|---|
| C# | Application development |
| Windows Forms | Desktop user interface |
| .NET | Application framework |
| MySQL | Relational database |
| ADO.NET | Database connectivity/data access |
| SQL | Database queries and schema |
| DataGridView | Tabular data management |
| CSV | Data export/reporting |

## Project Structure

```text
EstateFlow/
├── Forms/             # Windows Forms UI and Designer files
├── Models/            # Application data/entity models
├── Database/          # Database connection and query logic
├── Reports/           # Reporting and CSV export functionality
├── SQL/               # Database schema and migration scripts
├── Documentation/     # SRS, technical/user manuals and project docs
└── README.md          # Project documentation
```

## Core Modules

### Authentication
Provides application login functionality and supports role-aware access to the system.

### Property Management
Handles property records and provides CRUD operations together with search and filtering capabilities.

### Client & Agent Management
Maintains structured records for clients and agents involved in the real estate workflow.

### Sales Management
Stores sales-related information and connects real estate transactions with managed property records.

### Reporting
Allows application data to be exported to CSV for further processing, analysis, or record keeping.

## Database

EstateFlow uses **MySQL** as its relational database. The repository includes SQL resources intended to help create and configure the application's database structure.

Before running the application, configure the database connection according to your local MySQL environment and execute the provided SQL setup/migration scripts.

> **Security note:** Never commit real database passwords, API keys, connection secrets, or other credentials to the repository. Use local configuration or environment-specific settings instead.

## Getting Started

### Prerequisites

- Windows
- Visual Studio with C#/.NET desktop development support
- MySQL Server
- MySQL client/tooling such as MySQL Workbench (optional but recommended)

### Installation

1. Clone or download the repository.
2. Open the solution/project in Visual Studio.
3. Create the required MySQL database using the SQL scripts provided in the repository.
4. Configure the application's database connection for your local environment.
5. Restore/build the project dependencies.
6. Run the application from Visual Studio.

## Development Notes

The project is organized around separate UI, model, database, reporting, and documentation areas to make the codebase easier to understand and maintain. Generated Visual Studio build and user-specific files are excluded through `.gitignore`.

## Future Improvements

Potential improvements include:

- Modernizing the desktop UI/UX.
- Adding stronger authentication and permission management.
- Introducing automated unit and integration tests.
- Adding richer sales and financial analytics.
- Improving validation and error handling.
- Adding automated CI checks with GitHub Actions.
- Introducing configuration management for different environments.
- Adding screenshots and a short product demo to the project documentation.

## Project Status

**Active portfolio project / academic software project.**

The project can be extended with additional real estate workflows, reporting features, testing, and deployment improvements.

## Author

**Mujahid Sarfraz**

Computer Science student and software developer interested in **C#, .NET, WordPress, PHP, JavaScript, MySQL, and modern web/software development**.

---

If you find this project useful or have suggestions for improvement, feel free to open an issue or start a discussion.
