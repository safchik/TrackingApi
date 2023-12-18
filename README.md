Issue Tracking Web API with ASP.NET Core and .NET 6
This project provides an example of how to create a Web API using ASP.NET Core and .NET 6 for an issue tracking application. The Web API is a RESTful service that exposes a set of endpoints for managing issues. Additionally, this solution includes a console client application that consumes the Web API endpoints.

Getting Started
To run the application, follow these steps:

Clone the repository: git clone https://github.com/safchik/TrackingApi
Open the solution in Visual Studio or your favorite code editor.
Set the trackingapi project as the startup project.
Run the application.
The Web API uses a SQLite database to store issues but you can choose any EF Core provider you like. To run the client console application, follow these steps:

Right-click on the project tracking.client.
Run the application. The client application will use the Web API endpoints to perform various operations, including creating and updating issues, adding and deleting comments, and retrieving lists of issues.
