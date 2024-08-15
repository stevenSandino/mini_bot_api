namespace mini_bot_api.Interface
{
    public interface IDistributedLockUtils
    {
        void WithDistributedLock(String lockName, Func<Task> action);
    }
}
