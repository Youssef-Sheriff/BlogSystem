# Blog System

A simple blog system built with ASP.NET Core and Entity Framework, allowing users to create, read, update, and delete blog posts.

## Features
- Create, edit, and delete blog posts
- View a list of all posts
- Responsive UI using Bootstrap

## Getting Started

### Prerequisites
- .NET 8.0 SDK
- SQL Server

### Setup
1. Clone the repository:
   ```bash
   git clone https://github.com/Youssef-Sheriff/BlogSystem.git
   cd BlogSystem
   ```
2. Configure the connection string in `appsettings.json`:
   ```json
   "ConnectionStrings": {
     "DefaultConnection": "Server=YOUR_SERVER;Database=BlogSystem;Trusted_Connection=True;"
   }
   ```
3. Apply migrations:
   ```bash
   dotnet ef database update
   ```
4. Run the project:
   ```bash
   dotnet run
   ```
5. Access the app at `http://localhost:5000` (or the configured port).

### Publishing
To publish the project locally:
```bash
dotnet publish -c Release -o ./publish
```
The published files will be in the `publish/` folder.

## Deployment
You can deploy the project to Azure App Service, or any hosting provider that supports ASP.NET Core.

## Contributing
1. Fork the repository.
2. Create a new branch:
   ```bash
   git checkout -b feature-name
   ```
3. Commit changes:
   ```bash
   git commit -m "Add new feature"
   ```
4. Push and open a pull request.

## License
This project is open-source and available under the [MIT License](LICENSE).

## Contact
Youssef Sherif  
[GitHub](https://github.com/Youssef-Sheriff)  
[LinkedIn](https://www.linkedin.com/in/youssef--sherif/)  
[Email](mailto:sherify766@gmail.com)

---
Feel free to enhance this project and share your feedback!
