## Week 3 - Design Patterns

This document summarizes all design patterns covered during Week 3 of the Bridge Course.

For each pattern:
- Purpose
- Real-world example
- Where it appears later in ASP.NET Core/.NET
- Easy way to remember
- Example

## 1. Singleton Pattern

Purpose
Ensures only one instance of a class exists throughout the application.
 
Real-world Example
A Logger service where all parts of the application write logs through the same object.

Where I'll See It Later
Logging
Configuration
Caching

Easy Way to Remember
One class ? One object ? Shared everywhere

## Example
```csharp
Logger logger = Logger.Instance;
logger.Log("Application Started");
```

## 2. Factory Pattern

Purpose
Creates objects without exposing the object creation logic to the client.

Real-world Example
VehicleFactory creates Car, Bike, or Truck objects based on user input.

Where I'll See It Later
Service creation
Dependency Injection
Object factories

Easy Way to Remember
Instead of new, ask a Factory to create it.

## Example
```csharp
IVehicle vehicle = VehicleFactory.CreateVehicle("Car");
vehicle.Drive();
```

## 3. Factory Method Pattern

Purpose
Allows subclasses to decide which object should be created.

Real-world Example
Separate factories like CarFactory, BikeFactory, and TruckFactory.

Where I'll See It Later
Plugin systems
Different database providers

Easy Way to Remember
Each factory knows how to create only one product.

## Example
```csharp
IVehicleFactory factory = new CarFactory();
```

## 4. Observer Pattern

Purpose
Notifies multiple objects automatically whenever the subject changes.

Real-world Example
Stock market applications notifying investors when prices change.

Where I'll See It Later
C# Events
Event Handlers
Notifications

Easy Way to Remember
One publisher ? Many subscribers

## Example
```csharp
channel.UploadVideo("Design Patterns");

subscriber1.Update();
subscriber2.Update();
```

## 5. Strategy Pattern

Purpose
Allows switching algorithms or behaviors at runtime.

Real-world Example
Shopping cart choosing between Credit Card, UPI, or Net Banking payment.

Where I'll See It Later
Payment gateways
Authentication
Sorting algorithms

Easy Way to Remember
Same task, different ways of doing it.

## Example
```csharp
shoppingCart.SetPaymentStrategy(new CreditCardPaymentStrategy());

shoppingCart.Checkout(5000);
```

## 6. Repository Pattern
Purpose
Provides a common interface for CRUD operations and hides data access logic.

Real-world Example
StudentRepository, CourseRepository.

Where I'll See It Later
Entity Framework
Dapper
Database layer

Easy Way to Remember
One place for all database operations.

## Example
```csharp
studentRepository.Add(student);

studentRepository.GetById(1);
```

## 7. Unit of Work

Purpose
Coordinates multiple repositories and saves all changes together.

Real-world Example
Managing StudentRepository and CourseRepository through a single UnitOfWork.

Where I'll See It Later
Entity Framework DbContext
Transaction Management

Easy Way to Remember
One manager for many repositories.

## Example
```csharp
unitOfWork.StudentRepository.Add(student);

unitOfWork.CourseRepository.Add(course);

unitOfWork.Save();
```

## 8. Adapter Pattern

Purpose
Converts one interface or format into another so incompatible systems can work together.

Real-world Example
Converting JSON reports into XML for a third-party report generator.

Where I'll See It Later
Third-party integrations
Legacy system integration
API transformations

Easy Way to Remember
Translator between two incompatible systems.

## Example
```csharp
IReportGenerator generator =
    new XmlReportAdapter(new XmlReportGenerator());

generator.GenerateReport();
```

## 9. Facade Pattern
Purpose

Provides one simple interface to a complex subsystem.

Real-world Example

OrderFacade coordinating Inventory, Payment, and Shipping services.

Where I'll See It Later
Order processing
Payment workflows
Service orchestration
Easy Way to Remember

One button that performs many tasks.

## Example
```csharp
OrderFacade.PlaceOrder();
```

# Pattern Summary

| Pattern | Primary Purpose | Future Usage |
|---------|-----------------|--------------|
| Singleton | Single shared instance | Logging, Configuration, DI |
| Factory | Object creation | Services, Repositories, DI |
| Observer | Event notification | Events, SignalR, Notifications |
| Strategy | Runtime behavior selection | Payments, Discounts, Authentication |
| Repository | Data access abstraction | Entity Framework, Dapper, APIs |
| Unit of Work | Transaction management | Database transactions |
| Adapter | Interface conversion | Third-party integrations |
| Facade | Simplify complex workflows | Checkout, Registration |

## 10. Builder Pattern
Purpose

Builds complex objects step by step.

Real-world Example

Creating reports or configuring HTTP requests with many optional settings.

Where I'll See It Later
WebApplicationBuilder
Fluent APIs
Easy Way to Remember

Build one step at a time.

## 11. Prototype Pattern
Purpose

Creates new objects by cloning an existing object.

Real-world Example

Copying employee or configuration objects.

Where I'll See It Later
Configuration templates
Game development
Easy Way to Remember

Duplicate instead of recreate.

## 12. Decorator Pattern
Purpose

Adds new functionality to an object without modifying its original class.

Real-world Example

Adding logging or caching around a service.

Where I'll See It Later
ASP.NET Core Middleware
Logging
Authorization
Easy Way to Remember

Wrap an object to add extra behavior.

## 13. Command Pattern
Purpose

Encapsulates a request as an object.

Real-world Example

Undo/Redo operations in a text editor.

Where I'll See It Later
CQRS
Background jobs
UI actions
Easy Way to Remember

Every action becomes an object.

## 14. Template Method Pattern
Purpose

Defines the overall algorithm while allowing subclasses to customize individual steps.

Real-world Example

Generating different report types using the same workflow.

Where I'll See It Later
Base classes
Framework templates
Easy Way to Remember

Same process, customizable steps.

## 15. Mediator Pattern
Purpose

Reduces direct communication between objects by introducing a central coordinator.

Real-world Example

Chat server coordinating messages between users.

Where I'll See It Later
MediatR
Event-driven systems
Easy Way to Remember

Everyone talks through one mediator.

## 16. Chain of Responsibility Pattern

Purpose
Passes a request through multiple handlers until one handles it.

Real-world Example
ASP.NET Core Middleware pipeline.

Where I'll See It Later
Middleware
Validation pipelines

Easy Way to Remember
Pass it along until someone handles it.

## 17. State Pattern

Purpose
Changes an object's behavior based on its current state.

Real-world Example
Order lifecycle:
Pending ? Paid ? Shipped ? Delivered.

Where I'll See It Later
Workflow engines
State machines

Easy Way to Remember
Behavior changes when state changes.