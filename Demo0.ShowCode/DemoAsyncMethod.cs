using System.Collections.Generic;
using System.Threading.Tasks;

namespace Demo0.ShowCode
{
    public class DemoAsyncMethod
    {
        public async Task DelayOperationAsync()
        {
            BeforeCall();

            var users = await GetAllUsersAsync();

            AfterAwait(users);
        }

        private async Task<IList<User>> GetAllUsersAsync()
        {
            await Task.Delay(1000);

            return new List<User>();
        }

        private void BeforeCall()
        {
            
        }

        private void AfterAwait(IList<User> users)
        {
            var await = 1;
        }
    }
}