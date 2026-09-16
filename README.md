Dental Management System
Angular Patient Portal → ASP.NET Core API ← WinForms Staff Application

DMS is a Dental Management System designed to support a dental clinic.

The project consists of a .NET backend API, a WinForms desktop application for clinic staff (admin) , and an Angular web application for patients its .

The main goal of the project is to provide a clean and secure architecture for managing patients, appointments, medical information and user access.

* Architecture -> ASP.NET Core REST API / Clean architecture / CQRS 

The system consists of three main applications:

DMS API – ASP.NET Core REST API responsible for business logic, authorization and data access.
DMS Desktop – WinForms application designed for administrators, receptionists and doctors.
DMS Web – Angular patient portal allowing patients to access their own data and appointments.

1. Authentication & Authorization

Authentication is handled using Supabase Auth and JWT tokens.

The application supports role-based authorization with the following roles:

Patient
Admin
Doctor - under development
Receptionist - under development

JWT tokens are validated by the API, while application-specific roles are resolved from the DMS database.

2. Technology Stack
Backend
.NET / ASP.NET Core
REST API
Entity Framework Core
MediatR
JWT Authentication
Supabase Auth
Desktop
WinForms
.NET Framework
HttpClient
Web
Angular
Angular Material


3. Project Status:
The project is currently under development.

Implemented features include:

user authentication,
JWT-based API authorization,
role-based access control,
patient management,
desktop client integration with the API,
Angular patient login,
protected patient dashboard.

4. Planned features / goals include:

appointment management,
medical records and diagnoses,
doctor panel - currenty being developed in Dekstop app (will be migrated to Web),
receptionist panel,
patient visit history  
