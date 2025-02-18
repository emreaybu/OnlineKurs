# OnlineKurs
This project is a Windows Forms application developed using C# and Entity Framework, following a multi-layered architecture. It interacts with a custom SQL Server database to manage and display student information. The application provides functionalities for adding, updating, and deleting student records.

Features
Student Management: Allows users to view, add, update, and delete student records.
Data Persistence: Uses Entity Framework to interact with the SQL Server database for data storage and retrieval.
Real-time Updates: Automatically refreshes the student list after any operation like adding, updating, or deleting a student.
User-friendly Interface: Provides a simple and intuitive interface for managing student data.
Architecture
This application follows a multi-layered architecture for better maintainability and separation of concerns. 

The layers are:

UI Layer: The Windows Forms interface that interacts with the user.
Business Logic Layer: Contains the business rules for managing student data.
Data Access Layer: Interacts with the database using Entity Framework for CRUD operations.
Entities Layer: Defines the data models (e.g., Student class).

Technologies Used
C#
Entity Framework
SQL Server
Ninject (for Dependency Injection)
