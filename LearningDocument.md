# Week 1 – Exceptions, Async, Design Patterns & SOLID

**Name:** Ahash Raja


# Day 1

## Task 1.1 – Custom Exception Handling

### Objective

Create a custom `InsufficientFundsException` with a `DeficitAmount` property and understand exception handling using `try`, `catch`, and `finally`.

### What I Learned

- How to create a custom exception by inheriting from `Exception`.
- How to throw and catch business-specific exceptions.
- The purpose of `try`, `catch`, and `finally`.
- Why catch blocks must be ordered from specific exceptions to general exceptions.

### Key Points to Remember

- Every custom exception should inherit from `Exception`.
- `throw` immediately stops execution of the current method.
- Code after `throw` will not execute.
- `finally` always executes, even if an exception occurs.
- Always catch specific exceptions first and `Exception` last.
- Custom exceptions can carry additional information like `DeficitAmount`.

### Notes

**Q:** Why create a custom exception?

**A:** To represent business-specific errors and include additional context that built-in exceptions don't provide.

**Q:** Why is `Exception` always the last catch block?

**A:** Because it is the base class for all exceptions. Placing it first makes later catch blocks unreachable.

### Real Project Usage

- Validating business rules.
- Banking transactions.
- Order processing.
- Custom validation in enterprise applications.

---

## Task 1.2 – IDisposable & using

### Objective

Understand deterministic resource cleanup using `IDisposable`, `using`, finalizers, and `GC.SuppressFinalize()`.

### What I Learned

- How unmanaged resources differ from managed resources.
- Why some objects require explicit cleanup.
- How the `using` statement automatically calls `Dispose()`.
- Why finalizers are only a backup mechanism.

### Key Points to Remember

- `IDisposable` is used for releasing unmanaged resources.
- `using` guarantees that `Dispose()` is called.
- Don't rely on the Garbage Collector to release files or database connections.
- `GC.SuppressFinalize(this)` prevents unnecessary finalizer execution.
- Finalizers are non-deterministic—they run when the GC decides.

### Notes

**Q:** What is the difference between `Dispose()` and a finalizer?

**A:** `Dispose()` is called explicitly and releases resources immediately. A finalizer is called by the Garbage Collector at an unspecified time.

**Q:** Why use `using`?

**A:** It ensures resources are cleaned up even if an exception occurs.

### Real Project Usage

- `SqlConnection`
- `FileStream`
- `StreamReader`
- `StreamWriter`
- Dapper database connections

---

## Task 1.3 – Async/Await

### Objective

Understand asynchronous programming and compare sequential versus concurrent execution using `Task.WhenAll()`.

### What I Learned

- How `async` and `await` work together.
- Difference between sequential and concurrent execution.
- How `Task.WhenAll()` improves performance for independent operations.

### Key Points to Remember

- `async` enables asynchronous methods.
- `await` pauses the method without blocking the thread.
- `Task.WhenAll()` runs multiple independent tasks concurrently.
- `Task.WhenAll()` waits until all tasks complete.
- Use concurrent execution only when tasks don't depend on one another.
- `async` does **not** automatically create a new thread.

### Notes

**Q:** When should `Task.WhenAll()` be used?

**A:** When multiple independent asynchronous operations can run simultaneously.

**Q:** Does `async` create a new thread?

**A:** No. It enables non-blocking asynchronous operations; thread creation depends on the underlying operation.

### Real Project Usage

- Calling multiple Web APIs.
- Loading dashboard data.
- Running independent database queries.
- Reading multiple files concurrently.

----------------------------------------------------------------------------------------------

# Day 2 – Design Patterns

## Task 1.4 – Singleton Pattern

### Objective
Implement a thread-safe Logger Singleton using `Lazy<T>` and verify that multiple Threads and Tasks access the same object.

### What I Learnt

The Singleton Pattern ensures that only one instance of a class exists throughout the application's lifetime and provides a global access point to access it.

A Singleton class has:
- A private constructor to prevent object creation using `new`.
- A static property (`Instance`) to access the single object.
- A thread-safe implementation using `Lazy<T>`.

`Lazy<T>` creates the object only when it is first accessed (lazy initialization) and guarantees thread safety.

### Key Points to Remember

- Singleton = One object for the entire application.
- Constructor must be `private`.
- `Instance` is `static` because no object exists initially.
- `Lazy<T>` delays object creation until first use.
- Suitable for Logger, Configuration Manager, Cache, Settings Manager, etc.
- All Threads and Tasks receive the same instance.

---

# Task 1.5 – Factory Pattern & Factory Method

## Objective

Create vehicles using a Factory instead of directly creating objects using `new`.

### What I Learnt

The Factory Pattern centralizes object creation and hides implementation details from the caller.

Instead of:

```csharp
new Car();
```

the caller simply requests:

```csharp
VehicleFactory.CreateVehicle("Car");
```

The Factory decides which object to create.

Factory Method extends this concept by creating separate factories for each product.

Example:

- CarFactory
- BikeFactory
- TruckFactory

Each factory is responsible for creating one specific object.

### Key Points to Remember

- Factory hides object creation.
- Caller never creates objects directly.
- Factory reduces repeated `new` statements.
- Factory follows the Open/Closed Principle.
- Factory Method assigns one factory per product.
- Factory Method is easier to extend than a single large factory.

### Difference Between Factory and Factory Method

| Factory Pattern | Factory Method |
|-----------------|----------------|
| One factory creates all products | Each product has its own factory |
| Centralized object creation | Distributed object creation |
| Easier for smaller applications | Better for scalable applications |

---

# Task 1.6 – Observer Pattern

## Objective

Notify multiple investors whenever the stock price changes.

Implemented using:
1. Manual Observer Pattern
2. C# Events

### What I Learnt

The Observer Pattern establishes a one-to-many relationship between objects.

Whenever the Publisher changes its state, all subscribed Observers are automatically notified.

Real-life examples include:
- YouTube notifications
- WhatsApp messages
- Email subscriptions
- Stock market alerts

### Manual Observer

Created:
- IObserver
- Investor
- StockTicker

Implemented:
- Subscribe()
- Unsubscribe()
- Notify()

StockTicker maintained a list of observers and notified each one whenever the stock price changed.

### Observer using C# Events

Reimplemented the same scenario using C# Events.

Instead of maintaining a list manually, .NET handled subscriptions internally using events.

Used:
- event Action<string, decimal>
- += (Subscribe)
- -= (Unsubscribe)
- Invoke() (Notify)

This significantly reduced the amount of code.

### Manual Observer vs C# Events

| Manual Observer | C# Events |
|-----------------|-----------|
| List<IObserver> | Managed internally by .NET |
| Subscribe() | += |
| Unsubscribe() | -= |
| Notify() | Invoke() |
| foreach() | Managed internally |
| Update() | Event Handler |

### Key Points to Remember

- Observer Pattern creates a one-to-many relationship.
- Publisher doesn't know the concrete observers.
- Observers can subscribe and unsubscribe dynamically.
- C# Events are Microsoft's implementation of the Observer Pattern.
- Events internally use Delegates.
- Button.Click and TextBox.TextChanged are examples of Observer Pattern.

### Real-World Mapping

| Pattern | Real Example |
|----------|--------------|
| Singleton | Logger, Configuration Manager |
| Factory | Dependency Injection Container |
| Factory Method | ASP.NET Service Registration |
| Observer | Button.Click, TextChanged, Timer.Elapsed |

---

# Day 3 - Strategy, Repository+UoW, Adapter/Facade 

Strategy Pattern: 
Choose different algorithms or behaviors at runtime without changing the client code.

Repository Pattern: 
Centralizes CRUD operations and abstracts data access using a generic interface.

Unit of Work: 
Manages multiple repositories through a single object and provides a common Save() operation.

Adapter Pattern: 
Converts one interface or data format into another so incompatible systems can work together.

Facade Pattern: 
complex workflows by exposing a single method that internally coordinates multiple services.


# Day 4 - Reflection, TPL & Attributes

## Task 3.10 - Thread vs Task vs Parallel
- Thread is a low-level OS thread.
- Task is a higher-level abstraction that usually uses the Thread Pool.
- Parallel.ForEach automatically distributes CPU-bound work across available cores.
- Use Stopwatch to compare execution times.
- Avoid creating raw threads unless you have a specific need.

## Task 3.11 - Reflection
- Reflection allows code to inspect other code at runtime.
- Type represents metadata about a class.
- GetProperties(), GetMethods(), and GetConstructors() inspect a type.
- Activator.CreateInstance() creates objects dynamically.
- PropertyInfo.SetValue() and MethodInfo.Invoke() let you modify objects and invoke methods dynamically.
- Reflection powers frameworks like ASP.NET Core, Entity Framework, and JSON serializers.

## Task 3.12 - Custom Attributes
- Custom attributes inherit from the Attribute class.
- AttributeUsage specifies where an attribute can be applied.
- Reflection can retrieve attributes using GetCustomAttribute<T>().
- Custom validation can be implemented by combining Reflection and Attributes.
- ASP.NET Core's built-in validation attributes (e.g., [Required], [StringLength]) use the same concepts.