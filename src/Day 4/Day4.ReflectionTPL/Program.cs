using Day4.ReflectionTPL.Task110;
using Day4.ReflectionTPL.Task111;
using Day4.ReflectionTPL.Task112.Models;
using Day4.ReflectionTPL.Task112.Services;

internal class Program
{
    static async Task Main(string[] args)
    {
        // ===== Task 3.10 =====
        PerformanceComparison comparison = new PerformanceComparison();

        comparison.SequentialExecution();

        comparison.ThreadExecution();

        await comparison.TaskExecution();

        comparison.ParallelExecution();

        Console.WriteLine("\nPress any key...");
        Console.ReadKey();

        // ===== Task 3.11 =====
        ReflectionDemo demo = new ReflectionDemo();
        demo.Run();

        Console.WriteLine("\nPress any key...");
        Console.ReadKey();

        RunTask312();
        Console.ReadKey();
    }
    static void RunTask312()
    {
        Console.WriteLine("\n===== Task 3.12 - Custom Attributes =====\n");

        User user = new User
        {
            Name = "Ahash Raja dfghjuytrtyuioiuyt",
            City = "Chennai"
        };

        Validation validator = new Validation();

        validator.Validate(user);
    }
}
