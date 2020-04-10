using System;

namespace Demo8.Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            IUserService userService = new UserServiceV1();
            userService.FinishedTrialPeriod(new User());

            userService = new UserServiceV2();
            userService.FinishedTrialPeriod(new User());
        }
    }
}
