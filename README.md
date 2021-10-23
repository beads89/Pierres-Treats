# Pierre's Sweet and Savory Treats

#### An application that allows the user to view and categorize delicacies at a made up patisserie .

#### Created By: Brandon Eads

## Technologies Used

* C#
* .NET 5
* NuGet
* ASP.NET Core
* Entity Framework Core
* MySql
* MySql Workbench
* EF Core

## Description

This application allows the user to create a database of treats and flavors in a patisserie. The application represents a many to many relationship in which you are able to assign multiple treats to the same flavor and vice versa. The home page displays a list of all current treats and flavors that are being logged in the database. There are also options to view the lists serparately and edit each entity. Based on if a user is logged in they will have the ability to see different fields. When not logged in, a user is not able to add, edit, or remove any treats or flavors. If they are logged in, any user is able to add, edit, or remove a treat or flavor and assign them to other categories.


## Setup and Usage Instructions

### Technology Requirements

* Download and install [.NET 5](https://dotnet.microsoft.com/download/dotnet/5.0)
* Download and install a code text editor. Ex: [VS Code](https://code.visualstudio.com/)
* Download, install, and complete setup for [MySql Community Server](https://dev.mysql.com/downloads/file/?id=484914) and [MySql Workbench](https://dev.mysql.com/downloads/file/?id=484391).

### Installation

* Clone [this](https://github.com/beads89/Pierres-treats) repository, or download and open the Zip on your local machine
* Open the Pierre.Solution folder in your preferred text editor
* To install required packages, navigate to the terminal and type the following commands:
  - dotnet add package Microsoft.EntityFrameworkCore -v 5.0.0
  - dotnet add package Microsoft.EntityFrameworkCore.Design -v 5.0.0
  - dotnet add package Pomelo.EntityFrameworkCore.MySql -v 5.0.0-alpha.2
  - dotnet add package Microsoft.EntityFrameworkCore.Proxies -v 5.0.0
  - dotnet tool install --global dotnet-ef
* Create a file named "appsettings.json" in the Pierre directory
  - add the following code to the appsettings.json file:
  ```
  {
    "ConnectionStrings": {
        "DefaultConnection": "Server=localhost;Port=3306;database=brandon_eads;uid=root;pwd=[YOUR-PASSWORD-HERE];"
    }
  }
  ```
  - replace [YOUR-PASSWORD-HERE] with your unique MySql password
* To Import the required database, navigate to the terminal and type the following command:
  - dotnet ef database update
* To Restore, build, and run the project:
  - Navigate to the Pierre.Solutions/Pierre folder in the command line or terminal
    - Run the command "dotnet restore" to restore the project dependencies
    - Run the command "dotnet build" to build and compile the project
    - Run the command "dotnet run" to build and compile the project

## Known Bugs

* Currently able to create a flavor or treat with the same name as something already in the database.

### License

[MIT License](https://opensource.org/licenses/MIT)
Copyright 2021 Brandon Eads

## Support and contact details

* [Brandon Eads](github.com/beads89) <Brandon181989@hotmail.com>