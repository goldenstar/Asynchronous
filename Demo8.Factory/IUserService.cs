using System.Threading.Tasks;

namespace Demo8.Factory
{
    public interface IUserService
    {
        Task<bool> FinishedTrialPeriod(User user);
    }
}