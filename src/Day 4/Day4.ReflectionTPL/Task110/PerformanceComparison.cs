using System.Diagnostics;

namespace Day4.ReflectionTPL.Task110
{
    public class PerformanceComparison
    {
        private void SimulateWork(int id)
        {
            Thread.Sleep(100); // Simulate a 100ms task
            Console.WriteLine($"Processed Item {id}");
        }

        public void SequentialExecution()
        {
            Console.WriteLine("\n===== Sequential Execution =====");

            Stopwatch stopwatch = Stopwatch.StartNew();

            for (int i = 1; i <= 100; i++)
            {
                SimulateWork(i);
            }

            stopwatch.Stop();

            Console.WriteLine($"\nTime Taken : {stopwatch.ElapsedMilliseconds} ms");
        }
        public void ThreadExecution()
        {
            Console.WriteLine("\n===== Thread Execution =====");

            Stopwatch stopwatch = Stopwatch.StartNew();

            List<Thread> threads = new List<Thread>();

            for (int i = 1; i <= 100; i++)
            {
                int item = i; // Avoid closure issue
                Thread thread = new Thread(() => SimulateWork(item));
                threads.Add(thread);
                thread.Start();
            }

            foreach (Thread thread in threads)
            {
                thread.Join();
            }

            stopwatch.Stop();

            Console.WriteLine($"\nTime Taken : {stopwatch.ElapsedMilliseconds} ms");
        }
        public async Task TaskExecution()
        {
            Console.WriteLine("\n===== Task.Run Execution =====");

            Stopwatch stopwatch = Stopwatch.StartNew();

            List<Task> tasks = new List<Task>();

            for (int i = 1; i <= 100; i++)
            {
                int item = i;
                tasks.Add(Task.Run(() => SimulateWork(item)));
            }

            await Task.WhenAll(tasks);

            stopwatch.Stop();

            Console.WriteLine($"\nTime Taken : {stopwatch.ElapsedMilliseconds} ms");
        }
        public void ParallelExecution()
        {
            Console.WriteLine("\n===== Parallel.ForEach =====");

            Stopwatch stopwatch = Stopwatch.StartNew();

            Parallel.ForEach(Enumerable.Range(1, 100), item =>
            {
                SimulateWork(item);
            });

            stopwatch.Stop();

            Console.WriteLine($"\nTime Taken : {stopwatch.ElapsedMilliseconds} ms");
        }
    }
}