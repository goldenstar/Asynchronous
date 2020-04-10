using System;
using System.Threading.Tasks;

namespace Demo4.AsyncVoid
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

            #region

            // Console.ReadLine();

            #endregion
        }

        private static async void TestWrongBehaviorAsync()
        {
            await Task.Delay(100);

            throw new InvalidOperationException("Bad news.");
        }
    }
}
