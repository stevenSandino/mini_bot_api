using mini_bot_api.Interface;
using System.Net.NetworkInformation;

namespace mini_bot_api.Utils
{
    public class DistributedLockUtil : IDistributedLockUtils
    {
        protected string _env = "Local";
        public DistributedLockUtil() { }

        public async void WithDistributedLock(String lockName, Func<Task> action)
        {
            try
            {
                await action();
                System.Threading.Thread.Sleep(10 * 1000);
            }
            catch (Exception ex) 
            {
            }
        }
    }
}
