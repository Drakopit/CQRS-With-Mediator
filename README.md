# CQRS with MediatR Example  

This project demonstrates a simple implementation of the **CQRS (Command and Query Responsibility Segregation)** pattern using **MediatR**. It is designed to illustrate the separation of read and write operations while leveraging clean architecture principles.  

## Features  
- Separating commands (write operations) and queries (read operations).  
- Integration with **MediatR** for handling commands and queries.  
- Supports **InMemory** and **SQLite** databases for testing and development.  
- RESTful API endpoints for managing products.  

## Prerequisites  
- .NET 7 or higher installed on your system.  
- A code editor like Visual Studio or Visual Studio Code.  

## Technologies Used  
- **.NET 8**  
- **Entity Framework Core**  
- **MediatR**  
- **SQLite**  

## Project Structure  
The solution is divided into three projects:  
1. **CQRS.Domain**: Contains the domain entities, commands, queries, and handlers.  
2. **CQRS.Infra**: Includes the database context and repositories.  
3. **CQRS.Web**: Hosts the RESTful API and application configuration.  

## Run the Application
Run the API locally:

```bash
dotnet run --project CQRS.Web  
```
The API will be available at ``https://localhost:5001`` or ``http://localhost:5000``.

## Endpoints
| Method | Endpoint           | Description                   |
|--------|--------------------|-------------------------------|
| POST   | `/products`        | Create a new product          |
| PUT    | `/products/{id}`   | Update an existing product    |
| DELETE | `/products/{id}`   | Delete a product by ID        |
| GET    | `/products/{id}`   | Retrieve a product by ID      |
| GET    | `/products`        | Retrieve all products         |

## Example Payloads
### Create Product
```json
{  
  "name": "Example Product",  
  "price": 99.99  
}
```

### Update Product
```json
{  
  "id": 1,  
  "name": "Updated Product",  
  "price": 79.99  
}
```

## License
This project is licensed under the MIT License.

Feel free to explore and modify this example for your learning or development needs! 🚀