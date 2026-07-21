using Day1.Exceptions.Exceptions;
using Day1.Exceptions.Models;
using Day1.Exceptions.Services;
using Day1.Exceptions.Resources;
using Day1.Exceptions.Async;
using System.Diagnostics;

namespace Day1.Exceptions
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("========== BANKING SYSTEM ==========\n");

            BankAccount account = new BankAccount(
                "Ahash",
                5000);

            try
            {
                account.WithdrawAmount(12000);
            }
            catch (InsufficientFundsException ex)
            {
                Console.WriteLine("Exception Caught");
                Console.WriteLine(ex.Message);
                Console.WriteLine($"Deficit Amount :{ex.DeficitAmount}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Logger.Log("Withdrawal completed.");
            }
            //CatchOrderExample();
            TempFileExample();

            await SequentialExample();
            await ConcurrentExample();

            Console.WriteLine("\nPress any key...");
            Console.ReadKey();
        }
        static void CatchOrderExample()
        {
            Console.Write("Enter a number: ");

            string? input = Console.ReadLine();

            try
            {
                int number = int.Parse(input!);
                Console.WriteLine($"You entered:{number}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid format.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Number is too large.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        static void TempFileExample()
        {
            Console.WriteLine("TASK 3.2 - IDisposable");

            string tempFilePath;

            using (TempFileManager manager = new TempFileManager())
            {
                tempFilePath = manager.FilePath;

                Console.WriteLine($"\nInside using block");

                Console.WriteLine($"File Exists : {File.Exists(tempFilePath)}");
            }

            Console.WriteLine("\nOutside using block");

            Console.WriteLine($"File Exists : {File.Exists(tempFilePath)}");
        }
        static async Task SequentialExample() 
        {
            UserService user = new UserService();

            Stopwatch watch = Stopwatch.StartNew();
            await user.FetchUserDataAsync("Ahash");
            await user.FetchUserDataAsync("Alice");
            await user.FetchUserDataAsync("Bob");

            watch.Stop();
            Console.WriteLine($"Sequential Time :{watch.ElapsedMilliseconds} ms");
        }
        static async Task ConcurrentExample()
        {
            UserService service = new UserService();

            Stopwatch watch = Stopwatch.StartNew();
            Task t1 = service.FetchUserDataAsync("Ahash");
            Task t2 = service.FetchUserDataAsync("Alice");
            Task t3 = service.FetchUserDataAsync("Bob");

            await Task.WhenAll(t1, t2, t3);

            watch.Stop();
            Console.WriteLine($"Concurrent Time :{watch.ElapsedMilliseconds} ms");
        }
    }
}