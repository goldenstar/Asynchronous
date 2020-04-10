using System;
using System.Threading.Tasks;

namespace Demo9.Deadlock
{
    class Program
    {
        static void Main(string[] args)
        {
            StartWorkAsync().GetAwaiter().GetResult();

            Console.ReadLine();
        }

        private static async Task StartWorkAsync()
        {
            await Task.Delay(3000);
        }
    }
}
