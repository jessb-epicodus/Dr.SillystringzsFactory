# _Factory_

#### By _**Jessi Baker**_

#### _Factory - Epicodus - C# and .NET - Many-To-Many Relationships - Code Review_

## Technologies Used

* GIT
* CS
* ASP.NET MVC
* MYSQL
* Entity Framework
* LINQ

## Description

This is a web app is intended to help business manage their engineers and the machines they are licensed to fix.  A user should be able to add and view a list of engineers and machines and each of their respective details. 

## Setup/Installation Requirements

* This web app uses MySQL as a database.  Install & Account Setup: See _https://www.learnhowtoprogram.com/c-and-net/getting-started-with-c/installing-and-configuring-mysql_ for instructions
* Clone Repo: In your terminal navigate to your desktop or other desired location and enter `git clone https://github.com/jessb-epicodus/Factory.git`
* Import The Database Schema: In MySql Workbench, navigate to the administration tab, select Data Import/Restore & import _jessi_baker.sql_
* Add Required Packages: Navigate to the top level of the project directory called _ProjectName_ & enter each of the following commands.
  `dotnet add package Microsoft.EntityFrameworkCore -v 5.0.0`
  `dotnet add package Pomelo.EntityFrameworkCore.MySql -v 5.0.0-alpha.2`
  `dotnet add package Microsoft.EntityFrameworkCore.Proxies -v 5.0.0`
* Protect Your MySQL Password: Enter `touch .gitignore` & `touch appsettings.json` in the command line
* Add the following code to _appsettings.json_ & fill in your password where designated  
  `{  
    "ConnectionStrings": {  
      "DefaultConnection": "Server=localhost;Port=3306;database=jessi_baker_factory;uid=root;pwd=YOUR-PASSWORD-HERE;"  
    }  
  }`  
* Add _*/appsettings.json_ to _.gitignore_
* Install Dependeciey: Enter `dotnet restore` in your terminal
* Try Out This Web App: Enter `dotnet run` in the command line and navigte navigate to _http://localhost:5000/_ in your browser
* _This is not yet published_

## Known Bugs

* No known issues

## License

Copyright (c) _Mar 2022_ _Jessi Baker_

## Contact

_If you run into any issues or have questions, ideas or concerns or wish to make a contribution to the code see contact information below._
* Jessi Baker <jessb.epicodus@gmail.com>