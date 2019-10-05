# ASP.NET Core Exercises!

01_DI
Create WebAPI project using `dotnet new webapi` command. Register in Startup class 2 services to default Service Provider
- service A (choose better name if you want) registered as SCOPED
- service B (choose better name if you want) registered as SINGLETON
Inject via constructor service A into service B.
Run the app.
What happends?
Fix problem using IServiceProvider.

02_DI
Create WebAPI project using `dotnet new webapi` command. Register in Startup class 3 services to default Service Provider:
- all services implement same interface
- inject all services to WebAPI Controller using only one object(IEnumerable<T>)
- use all services in one of the Controller's action

03_Middleware
Create Empty ASP.NET Core project. Create cutom middleware class and add it to the app request pipeline in Startup class:
- custom middleware class should read data from URL query and add data as an request header

04_Logging
Create WebAPI project using `dotnet new webapi` command. Add fallowing changes to the app:
- Add logging to Controller's action and log info about request origin
- Log some message in Configure method in Startup class
- *Add logging to Program class and log something similar to "App is starting!"

05_Logging
Create WebAPI project using `dotnet new webapi` command or use one from exercise 04_Logging. Add fallowing changes to the app:
- Add Third-party logging provider
- Configure it to log messeages into file.

06_Configuration
Create WebAPI project using `dotnet new webapi` command. Add fallowing changes to the app:
- Inject interface IConfiguration to scaffolded Controller 
- Read from configuration file and return value as an response to Controller's action.
- Add another COntroller's action that will return value from configuration file depends on Environment!

06_Configuration
Create WebAPI project using `dotnet new webapi` command. Add fallowing changes to the app:
- Inject interface IConfiguration to scaffolded Controller 
- Add custom config file
- Bind custom config file to class during app startup
- Consume data from custom config using binded class in Controller's action