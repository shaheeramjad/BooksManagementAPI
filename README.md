# BookManagementAPI

Book Management System API's
Introduction
The Book Management System is a web-based API built using ASP.NET Core Web API. It follows a 3-layer architecture to separate concerns and improve maintainability. Users can manage books efficiently by performing CRUD operations such as adding, updating, deleting, and viewing books.

 Features
✔️ 3-Layer Architecture: Divided into Presentation (API Layer), Business Logic Layer (BLL), and Data Access Layer (DAL) for better structure and maintainability.
✔️ Manage Books: Perform Create, Read, Update, and Delete (CRUD) operations.
✔️ Bulk Operations: Add multiple books at once and delete books in bulk.
✔️ Check Popularity: Retrieve books based on their popularity count.
✔️ Database Integration: Uses SQL Server for data storage.
✔️ Implements Unit of Work and Repository Pattern for efficient data management.

🛠 Technologies Used
🔹 Backend: ASP.NET Core Web API (.NET 8)
🔹 Database: SQL Server
🔹 Architecture: 3-Layer Architecture (API, Business Logic, Data Access)

🔧 Installation & Setup
1️ Clone the Repository
🔗 GitHub Repository

2️ Backend Setup (ASP.NET Core Web API)
Open the project in Visual Studio 2022.

Configure the database connection in appsettings.json:

json
Copy
Edit
"ConnectionStrings": {
  "DefaultConnection": "Server=server_name;Database=dbName;Trusted_Connection=True;TrustServerCertificate=True;MultipleActiveResultSets=true"
},
Apply database migrations using the following command in the Package Manager Console:

sh
Copy
Edit
update-database
Contact
For any queries, feel free to reach out:

📩 Email: stansari4500@gmail.com
🔗 LinkedIn: [Shaheer Amjad](https://www.linkedin.com/in/shaheer-amjad-software-engineer/)
