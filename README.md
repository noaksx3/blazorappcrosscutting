# Cross Cutting with Blazor Apps
This application demonstrates how to cross-cut between a data access layer (Entity Framework Core) and a Core/Business layer using Automapper.

## Why do this?
Software architecture is king when it comes to being able to easily modify code, fix bugs, add features, or anything that might require looking at the existing code base and adding to it. Specifically, software architecture promotes clean code by using known design patterns (https://refactoring.guru/design-patterns/csharp) and also following SOLID principles of software development (https://www.c-sharpcorner.com/UploadFile/damubetha/solid-principles-in-C-Sharp/). 

## How is this done?
Simply put: interfaces. In C#, interfaces are your friend, and allow you to abstract the concrete implementation away from the higher layers in the application, such as a business logic or even a presentation layer where your user interface project exists, such as a Blazor application.

## Ok, interfaces it is! So what's the problem?
Glad you asked! Some technologies, such as Entity Framework Core, do not play nice wtih using interfaces, and this is mainly due to the concrete nature of how Entity Framework Core works with DbContexts, and also with Entity Framework Tools, such as code-first migrations. Simply put, EFCore does not play nice with abstraction, and so there must be a way to 