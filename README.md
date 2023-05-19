# Backend C# API Challenge

This is a coding challenge to evaluate your skills in C#, ASP.NET Web API, LINQ, classes, and SQL databases. The challenge involves creating a product management API that allows basic CRUD operations for products and stores the data in a SQL Server database.

## Requirements

- Implement a RESTful API using ASP.NET Web API with the following endpoints:
  - `GET /api/products`: Get all products.
  - `GET /api/products/{id}`: Get a specific product by its ID.
  - `POST /api/products`: Create a new product.
  - `PUT /api/products/{id}`: Update an existing product.
  - `DELETE /api/products/{id}`: Delete an existing product.

- Use a SQL Lite database to store the product data. You can utilize Entity Framework for interacting with the database.

- Each product should have at least the following fields: ID, Name, Description, Price, and Stock Quantity.

- Utilize LINQ for querying and manipulating data in the database.

- Implement appropriate classes and structures to represent products and related objects.

- The API should validate input data and handle possible errors gracefully.

- Include basic API documentation for other developers to understand how to use it. The use of Swagger with DataAnottations is recommended.

## Additional Points (Optional)

You can earn extra points by implementing the following additional features:

- Pagination for the list of products.
- Filtering and sorting options for the list of products.
- Basic authentication and authorization to secure the API.
- Implementing services with interfaces with Dependency Injection using the Singleton pattern: 

## Getting Started

To get started with the challenge, follow these steps:

1. Clone this repository to your local machine.
2. Set up the SQL Server database and update the connection string in the app configuration file.
3. Build and run the application.
4. Test the API endpoints using a tool like Postman.

## Project Structure

```
Backend C# Challenge/
├─ Controllers/
│  └─ StartController.cs
├─ Services/
│  └─ GreetingsService.cs
├─ DB/
│  ├─ {Table Structure SQL files}
│  └─{SQLite Database files}
├─ Models/
│  └─ {Object classes}
├─ appsettings.json
├─ Program.cs
└─ Startup.cs
```

- Controllers: This folder contains the API controllers responsible for handling the incoming requests and returning the responses. In this case, you would have a StartController.cs as an example.

- Services: The Services folder holds the service classes that encapsulate the business logic and data operations related to products. In this example, there is GreetingsService.cs class implementing the functionality of StartController.

- DB: This folder contains the database-related files. Here should be the files that contain the SQL statements to create the database schema, as well as the SQLite database itself. 

- Models: The Models folder contains the entity classes representing the product data and any other related entities. In this case, there would be a Product.cs class defining the properties and structure of a product.

- appsettings.json: This file typically contains the application settings, including the database connection string and other configuration options.

- Program.cs and Startup.cs: These files are part of the ASP.NET Web API project template and are responsible for the application's entry point and configuration.

Feel free to create or change the folders you consider necessary, as long as you have a valid reason to do so

## Submission

Please fork this repository and create a new branch for your solution. Once you have completed the challenge, submit a pull request with your code. Include any instructions or notes in the pull request description if necessary.

## Good Luck!

We hope you enjoy working on this challenge. If you have any questions, feel free to reach out. Happy coding!
