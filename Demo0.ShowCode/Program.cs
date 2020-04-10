using System;
using System.Threading.Tasks;

namespace Demo0.ShowCode
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Hello Mastery 5.0!");

            var demoAsyncMethod = new DemoAsyncMethod();
            await demoAsyncMethod.DelayOperationAsync();
        }
    }
}
