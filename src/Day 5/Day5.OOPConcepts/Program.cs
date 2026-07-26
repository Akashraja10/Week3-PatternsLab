using System;
using Day5.OOPConcepts.Task113a.Interfaces;
using Day5.OOPConcepts.Task113a.Abstracts;
using Day5.OOPConcepts.Task113a.Models;
using Day5.OOPConcepts.Task113b.Utilities;
using Day5.OOPConcepts.Task113b.Services;
using Day5.OOPConcepts.Task114.Models;
using Day5.OOPConcepts.Task114.Comparers;


internal class Program
{
    static void Main(string[] args)
    {
        Task113a();
        Task113b();
        RunTask114();
    }
    static void Task113a()
    {
        Console.WriteLine("===== Interface Example =====");

        IVehicle car = new Car();
        car.Start();
        car.Stop();

        Console.WriteLine();

        Console.WriteLine("===== Abstract Class Example =====");

        Developer developer = new Developer("Ahash", 90000);
        developer.CalculateSalary();
        Console.ReadKey();
    }
    static void Task113b()
    {
        Console.WriteLine("===== Static Methods =====");
        Console.WriteLine($"Factorial(5) : {MathHelper.Factorial(5)}");
        Console.WriteLine($"IsPrime(13) : {MathHelper.IsPrime(13)}");
        Console.WriteLine($"GCD(24,36) : {MathHelper.GCD(24, 36)}");

        Console.WriteLine();

        Console.WriteLine("===== Instance Methods =====");

        OrderProcessor processor = new OrderProcessor("Ahash", 1200);
        processor.PlaceOrder();
        processor.GenerateInvoice();

        Console.ReadKey();
    }
    static void RunTask114()
    {
        Console.WriteLine("===== Sorting Employees =====\n");

        List<Employees> employees = new List<Employees>
    {
        new Employees { EmployeeId = 1, Name = "David", Salary = 90000 },
        new Employees { EmployeeId = 2, Name = "Alice", Salary = 65000 },
        new Employees { EmployeeId = 3, Name = "John", Salary = 120000 },
        new Employees { EmployeeId = 4, Name = "Bob", Salary = 72000 },
        new Employees { EmployeeId = 5, Name = "Emma", Salary = 88000 },
        new Employees { EmployeeId = 6, Name = "Chris", Salary = 95000 },
        new Employees { EmployeeId = 7, Name = "Sophia", Salary = 110000 },
        new Employees { EmployeeId = 8, Name = "Kevin", Salary = 70000 },
        new Employees { EmployeeId = 9, Name = "Ahash", Salary = 98000 },
        new Employees { EmployeeId = 10, Name = "Zara", Salary = 60000 }
    };

        Console.WriteLine("Sort By Salary (Default)\n");
        employees.Sort();
        PrintEmployees(employees);

        Console.WriteLine("\nSort By Name\n");
        employees.Sort(new EmployeeNameComparer());
        PrintEmployees(employees);

        Console.ReadKey();
    }
    static void PrintEmployees(List<Employees> employees)
    {
        foreach (Employees employee in employees)
        {
            Console.WriteLine(
                $"{employee.EmployeeId,-3} " +
                $"{employee.Name,-10} " +
                $"{employee.Salary}");
        }
    }
}