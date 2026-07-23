using Day2.DesignPatterns.Singleton;
using Day2.DesignPatterns.Factory.Interfaces;
using Day2.DesignPatterns.Factory.Factories;
using Day2.DesignPatterns.Factory.Vehicle;
using Day2.DesignPatterns.Observer.Interfaces;
using ManualObserver = Day2.DesignPatterns.Observer.Models;
using EventObserver = Day2.DesignPatterns.ObserverEvents.Models;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Day2.DesignPatterns
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            // Task 3.4
            await SingletonDemo();

            // Task 3.5
            FactoryDemo();

            //Task 3.6
            ManualObserverDemo();
            EventObserverDemo();

        }

        static async Task SingletonDemo()
        {
            Console.WriteLine("===== Singleton Pattern =====\n");
            List<Thread> threads = new();
            // Create 5 Threads
            for (int i = 1; i <= 5; i++)
            {
                int id = i;

                Thread thread = new Thread(() =>
                {
                    Logger.Instance.Log($"Thread {id}");
                });

                threads.Add(thread);
            }
            // Start Threads
            foreach (Thread thread in threads)
            {
                thread.Start();
            }
            // Wait for all Threads
            foreach (Thread thread in threads)
            {
                thread.Join();
            }

            Console.WriteLine("\n===== Using Tasks =====\n");

            List<Task> tasks = new();
            // Create 5 Tasks
            for (int i = 1; i <= 5; i++)
            {
                int id = i;

                tasks.Add(Task.Run(() =>
                {
                    Logger.Instance.Log($"Task {id}");
                }));
            }

            await Task.WhenAll(tasks);

            Console.WriteLine("\nPress any key...");
            Console.ReadKey();
        }
        static void FactoryDemo()
        {
            // Factory Pattern
            Console.WriteLine("===== Factory Pattern =====\n");
            IVehicle vehicle1 = VehicleFactory.CreateVehicle("Car");

            vehicle1.Start();
            vehicle1.Stop();

            Console.WriteLine("\nPress any key...");
            Console.ReadKey();

            //Factory Method
            Console.WriteLine("===== Factory Method =====\n");
            IVehicleFactory factory = new CarFactory();

            IVehicle vehicle2 = factory.CreateVehicle();

            vehicle2.Start();
            vehicle2.Stop();

            Console.WriteLine("\nPress any key...");
            Console.ReadKey();

        }
        static void ManualObserverDemo()
        {
            // Observer Pattern
            Console.WriteLine("===== Observer Pattern =====\n");
            ManualObserver.StockTicker ticker = new();

            ManualObserver.Investor ahash = new ManualObserver.Investor("Ahash");
            ManualObserver.Investor alice = new ManualObserver.Investor("Alice");
            ManualObserver.Investor bob = new ManualObserver.Investor("Bob");

            ticker.Subscribe(ahash);
            ticker.Subscribe(alice);
            ticker.Subscribe(bob);

            ticker.UpdatePrice("AAPL", 150);
            Console.WriteLine();

            ticker.UnSubscribe(alice);
            ticker.UpdatePrice("GOOGL", 2800);

            Console.WriteLine("\nPress any key...");
            Console.ReadKey();
        }
        static void EventObserverDemo()
        {
            // Events
            EventObserver.StockTicker ticker = new();

            EventObserver.Investor ahash = new EventObserver.Investor("Ahash");
            EventObserver.Investor alice = new EventObserver.Investor("Alice");
            EventObserver.Investor bob = new EventObserver.Investor("Bob");

            // Subscribe
            ticker.PriceChanged += ahash.ReceiveNotification;
            ticker.PriceChanged += alice.ReceiveNotification;
            ticker.PriceChanged += bob.ReceiveNotification;

            ticker.UpdatePrice("Microsoft", 520);

            Console.WriteLine();

            // Unsubscribe
            ticker.PriceChanged -= alice.ReceiveNotification;

            ticker.UpdatePrice("Microsoft", 540);

            Console.ReadKey();
        }
    }
}