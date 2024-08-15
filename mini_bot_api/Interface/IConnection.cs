using System.Data;

namespace mini_bot_api.Interface
{
    public interface IConnection
    {
        IDbConnection GetConnection();
    }
}
