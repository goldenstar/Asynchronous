using System;
using System.Threading;
using System.Threading.Tasks;

namespace Demo6.TaskResult
{
    class Program
    {
        public static async Task Main(string[] args)
        {
            Console.WriteLine($"Main -> Test -> Thread id: {Thread.CurrentThread.ManagedThreadId}");

            await TestThreadIdAsync();
        }

        private static async Task TestThreadIdAsync()
        {
            Console.WriteLine($"TestThreadIdAsync -> Before delay -> Thread id: {Thread.CurrentThread.ManagedThreadId}");

            await Task.FromResult(1);

            Console.WriteLine($"TestThreadIdAsync -> After delay -> Thread id: {Thread.CurrentThread.ManagedThreadId}");
        }
    }
}
