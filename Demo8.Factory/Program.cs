using System;

namespace Demo8.Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User
            {
                CreatedDate = DateTime.Now,
            };

            IUserService userService;

            if (user.CreatedDate.Second % 2 == 0)
            {
                userService = new UserServiceV1();
                userService.FinishedTrialPeriod(user);
                userService.GetFreeDays(user);
            }
            else
            {
                userService = new UserServiceV2();
                userService.FinishedTrialPeriod(user);
                userService.GetFreeDays(user);
            }
        }
    }
}
