using System;

namespace Day2.DesignPatterns.Singleton
{
    public sealed class Logger
    {
        // Lazy<T> creates the instance only when it is first needed
        private static readonly Lazy<Logger> _instance =
            new Lazy<Logger>(() => new Logger());

        private Logger()
        {
            Console.WriteLine("Logger instance created.");
        }

        public static Logger Instance => _instance.Value;

        public void Log(string message)
        {
            Console.WriteLine($"[{DateTime.Now:HH:mm:ss}] " + 
                $"HashCode: {GetHashCode()} | {message}");
        }
    }
}