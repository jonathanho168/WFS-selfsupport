# WFS-selfsupport

## Introduction

The portal is a web-based application designed to automate many routine processes for Wesley Family Services, a Pittsburgh-based nonprofit organization.

### Current Features

As of this writing, this self-service portal allows managers to directly unapprove timesheets, enabling employees to make necessary corrections. This reduces the dependency on IT staff and streamlines payroll processing.

### Technical Features

- **Manager Payroll Management:** Allows managers to unapprove timesheets directly.
- **Audit Trail:** Records all actions to ensure compliance and accountability.
- **Integration:** Seamlessly integrates with existing WFS systems like Epicor HCM and SQL Server databases.
- **Security:** Leverages Active Directory for authentication, ensuring that only authorized personnel can access the portal and features within the portal.

## Getting Started

### Prerequisites
- .NET 7.0 SDK
- Microsoft SQL Server 2019
- IIS (Internet Information Services) configured with ASP.NET Core hosting

### Installation (Developer Sandbox)
- Clone the repository
- Open the solution in Visual Studio
- Build and run the project

### Updating for Production
- Update the connection strings in `WFSPortal/appsettings.json` to point to the production database. Currently, the string in use is called `DefaultConnection`, which points to the developer sandbox database.
- Navigate to `WFSPortal/Databases`. For each script, update the database name to match the production database name. Currently, the first line in each script reads `USE [EpicorHCMCMU2024]`, which is the developer sandbox database name.
- Run all three scripts in the production database to create the necessary tables and stored procedures. The order in which these scripts must be run is indicated by the number at the beginning of the file name.
- Build and run the project to confirm that the application is working as expected.
- After this, deploy the project to IIS.