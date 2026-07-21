using System;
using System.IO;

namespace Day1.Exceptions.Resources
{
    public class TempFileManager : IDisposable
    {
        private bool _disposed = false;

        public string FilePath { get; }

        public TempFileManager()
        {
            FilePath = Path.Combine(
                Path.GetTempPath(),
                $"TempFile_{Guid.NewGuid()}.txt");

            File.WriteAllText(FilePath, "Temporary File Created");

            Console.WriteLine($"Temp file created:");
            Console.WriteLine(FilePath);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (_disposed)
                return;

            Console.WriteLine("\nDispose() called.");

            if (File.Exists(FilePath))
            {
                File.Delete(FilePath);
                Console.WriteLine("Temporary file deleted.");
            }

            _disposed = true;
        }

        // Finalizer
        ~TempFileManager()
        {
            Console.WriteLine("\nFinalizer called.");

            Dispose(false);
        }
    }
}