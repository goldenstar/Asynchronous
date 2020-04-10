using System;
using System.Threading.Tasks;

namespace Demo5.AwaitTask
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Hello Mastery 5.0!");

            try
            {
                TestWrongBehaviorAsync();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("See you :)");

            // await Task.Delay(1000);
        }

        private static async Task TestWrongBehaviorAsync()
        {
            await Task.Delay(100);

            throw new InvalidOperationException("Bad news");
        }
    }
}
