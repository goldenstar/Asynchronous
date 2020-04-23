using System;
using System.Threading;
using System.Threading.Tasks;

namespace Demo5.AwaitTask
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine($"Main1 - {Thread.CurrentThread.ManagedThreadId}");

            try
            {
                await TestWrongBehaviorAsync();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine($"Main2 - {Thread.CurrentThread.ManagedThreadId}");

            Console.WriteLine("See you :)");
        }

        private static async Task TestWrongBehaviorAsync()
        {
            await Task.Delay(1000);

            Console.WriteLine($"TestWrongBehaviorAsync - {Thread.CurrentThread.ManagedThreadId}");

            throw new InvalidOperationException("Bad news :(");
        }
    }
}
