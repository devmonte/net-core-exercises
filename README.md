# ASP.NET Core Exercises!

##### 01_DI
Create WebAPI project using `dotnet new webapi` command. Register in Startup class 2 services to default Service Provider
- service A (choose better name if you want) registered as SCOPED
- service B (choose better name if you want) registered as SINGLETON
Inject via constructor service A into service B.
Run the app.
What happends?
Fix problem using IServiceProvider.

##### 02_DI
Create WebAPI project using `dotnet new webapi` command. Register in Startup class 3 services to default Service Provider:
- all services implement same interface
- inject all services to WebAPI Controller using only one object(IEnumerable<T>)
- use all services in one of the Controller's action

03_Middleware
Create Empty ASP.NET Core project. Create cutom middleware class and add it to the app request pipeline in Startup class:
- custom middleware class should read data from URL query and add data as an request header

##### 04_Logging
Create WebAPI project using `dotnet new webapi` command. Add fallowing changes to the app:
- Add logging to Controller's action and log info about request origin
- Log some message in Configure method in Startup class
- *Add logging to Program class and log something similar to "App is starting!"

##### 05_Logging
Create WebAPI project using `dotnet new webapi` command or use one from exercise 04_Logging. Add fallowing changes to the app:
- Add Third-party logging provider
- Configure it to log messeages into file.

##### 06_Configuration
Create WebAPI project using `dotnet new webapi` command. Add fallowing changes to the app:
- Inject interface IConfiguration to scaffolded Controller 
- Read from configuration file and return value as an response to Controller's action.
- Add another COntroller's action that will return value from configuration file depends on Environment!
- Read from Env variables

##### 07_Options
Create WebAPI project using `dotnet new webapi` command. Add fallowing changes to the app:
- Add separate json file with some data in it,
- Add json file to App Configuration,
- Bind data from json file to class using Configure method in Startup class,
- Use binded class in COntroller by injectin `IOptionsMonitor<T>` interface

##### 08_Routing
Create MVC project using `dotnet new mvc` command or Visual Studio. Add fallowing changes to the app:
- Add new MVC controller with action that return some string value
- Add dedicated convention-based routing in Startup class for created controller
- Add new WebAPI controller with attribute routing and 3 actions:
	- First action with `[HttpGet("<choose value here>")]` attribute
	- Second action with `[Route("<choose value here>")]` attribute
	- Third action with `[Route("/<choose value here>")]` attribute
- Change Starup class to handle attribute routing
- Check if all actions are accessible

##### 09_ViewsInMvc
Create MVC project using `dotnet new mvc` command or Visual Studio. Add fallowing changes to the app:
- Add new empty MVC controller and 3 different actions
- Every action should return different view
- Add partial view to one of the views
- Add different layout to views for created controller

##### 10_ViewsAndData
Create MVC project using `dotnet new mvc` command or Visual Studio. Add fallowing changes to the app:
- Add new empty MVC controller and 3 different actions
- Every action should return different view
- First action should pass data to view using `ViewData` object
  - *Use `[ViewData]` attribute
- Second action should pass data to view using `ViewBag` object
- Third action should pass data to view using strongly typed model
- *Add partial view to every view and pass data

##### 11_TagHelpers
Create MVC project using `dotnet new mvc` command or Visual Studio. Add fallowing changes to the app:
- Add new empty MVC controller and 3 different actions
- Every action should return different view
- Inevery view use at least one different tag helper:
  -anchor tag helper
  -environment tag helper
  -form tag helper
- Create custom tag helper

##### 12_RazorAndTagHelpers
Create MVC project using `dotnet new mvc` command or Visual Studio. Add fallowing changes to the app:
- Add new empty MVC controller and 4 different actions:
  - Index
  - IfStatement
  - ForEachLoop
  - Environment
- Add link to Index action to default Layout using anchor tag helper
- Add class Student with at least 3 public properties
- Add view for Index action and create there object of Student class using data from ViewData or using casting
- Add view for IfStatement action and create there if else statement based on data from ViewBag and showing different buttons depends on data
- 

##### 13_LibraryCRUD
Using ASP.NET Core MVC create an app, that will have fallowing functionality:
- 3 tables:
  - Authors
  - Books
  - Clients
- Relations:
  - Author can have many books
  - Book can have many authors
  - Client can borrow many boks
- Create service for seeding data
- Create controllers and views for CRUD operations

##### 14_LibraryCRUD
Using created app from exercise #14 add following changes:
- Add model validation
- 
