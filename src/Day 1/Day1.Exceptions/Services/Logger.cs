using System;

namespace Day1.Exceptions.Services
{
	public static class Logger
	{
		public static void Log(string message)
		{
            Console.WriteLine($"LOG : {message}");
            Console.WriteLine($"Time: {DateTime.Now}");
        }
	}
}
