using System;
using Day3.RepositoryPatterns.Repository.Models;
using Day3.RepositoryPatterns.Repository.UnitOfWork;
using Day3.RepositoryPatterns.Strategy.Payments;
using Day3.RepositoryPatterns.Adapter;
using Day3.RepositoryPatterns.Facade;

class Program
{
    static void Main(string[] args)
    {
        StrategyDemo();
        RepositoryDemo();
        AdapterDemo();
        FacadeDemo();
    }
    static void StrategyDemo()
    {
        Console.WriteLine("===== Strategy Pattern =====");

        ShoppingCart cart = new ShoppingCart();

        cart.SetPaymentStrategy(new CreditCardPaymentStrategy());
        cart.Checkout(5000);

        Console.WriteLine();

        cart.SetPaymentStrategy(new UpiPaymentStrategy());
        cart.Checkout(2500);

        Console.WriteLine();

        cart.SetPaymentStrategy(new NetBankingPaymentStrategy());
        cart.Checkout(8000);
        Console.ReadKey();
    }
    static void RepositoryDemo()
    {
        Console.WriteLine("\n===== Repository + Unit Of Work =====");

        UnitOfWork unitOfWork = new UnitOfWork();

        unitOfWork.Students.Add(new Student
        {
            Id = 1,
            Name = "Ahash",
            Age = 26
        });

        unitOfWork.Students.Add(new Student
        {
            Id = 2,
            Name = "Alice",
            Age = 22
        });

        var getAllStudents = unitOfWork.Students.GetAll();

        Console.WriteLine("\nStudents:");

        foreach (Student student in getAllStudents)
        {
            Console.WriteLine($"{student.Id} - {student.Name} - {student.Age}");
        }

        unitOfWork.Courses.Add(new Course
        {
            Id = 101,
            CourseName = ".NET",
            DurationInMonths = 6
        });

        var getAllCourses = unitOfWork.Courses.GetAll();

        Console.WriteLine("\nCourses:");

        foreach (Course course in getAllCourses)
        {
            Console.WriteLine($"{course.Id} - {course.CourseName}");
        }

        unitOfWork.Save();
        Console.ReadKey();
    }
    static void AdapterDemo()
    {
        Console.WriteLine("\n===== Adapter Pattern =====");

        JsonReport report = new JsonReport
        {
            CustomerName = "Ahash",
            Amount = 5000
        };

        XmlReportAdapter adapter = new XmlReportAdapter();

        adapter.GenerateReport(report);
        Console.ReadKey();
    }
    static void FacadeDemo()
    {
        Console.WriteLine("\n===== Facade Pattern =====");
        OrderFacade orderFacade = new OrderFacade();
        orderFacade.PlaceOrder(1000);

        Console.ReadKey();
    }
}
