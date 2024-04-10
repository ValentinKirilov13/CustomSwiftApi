# Custom Web API for Swift MT799 Messages Processing

This project is a custom Web API built using .NET 8 framework specifically designed to handle Swift MT799 messages. The API is responsible for accepting these messages, extracting relevant fields, and storing them into a SQLite database. Communication with the database is managed using ADO.NET. The project follows a layered architecture consisting of repository, service, and API layers. It includes data validation and exception handling mechanisms, with Serilog utilized for logging purposes. Connection strings are stored in user secrets for security purposes.

## Features

- **Swift MT799 Message Handling**: Accepts files with Swift MT799 messages and extracts fields.
- **SQLite Database Interaction**: Stores extracted fields into a SQLite database.
- **Layered Architecture**: Separation of concerns with repository, service, and API layers.
- **Data Validation**: Ensures data integrity through validation mechanisms.
- **Exception Handling**: Implements exception handling for robust error management.
- **Logging with Serilog**: Logs events and errors using Serilog for easy monitoring.

## Components

### Repository Layer
- Manages database connection and query execution.
- Handles interaction with the SQLite database.

### Service Layer
- Maps models and DTOs.
- Provides business logic for processing Swift MT799 messages.

### API Layer
- Provides HTTP endpoint for accepting files with Swift MT799 messages.
- Transforms incoming messages into DTO objects.
- Handles validation and exception handling for API requests.

## Installation

1. **Clone the repository:**
   ```bash
   git clone https://github.com/ValentinKirilov13/CustomSwiftApi.git
2. Navigate to the project directory:
   ```bash
   cd CustomSwiftApi
3. Restore dependencies:
   ```bash
   dotnet restore
4. Set up user secrets for connection string:
   ```bash
   dotnet user-secrets set "ConnectionStrings:SQLiteConnectionString" "Your_Connection_String_Here"
5. Build and run the project:
   ```bash
   dotnet build
   dotnet run
## Usage
1. Send a POST request to the API endpoint with the file with Swift MT799 message in the request body.
2. The API will process the message, extract relevant fields, and store them into the SQLite database.

## Contributing
Contributions are welcome! If you'd like to contribute to this project, please follow these steps:

1. Fork the repository.
2. Create your feature branch (git checkout -b feature/your-feature).
3. Commit your changes (git commit -am 'Add some feature').
4. Push to the branch (git push origin feature/your-feature).
5. Create a new Pull Request.
