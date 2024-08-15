using Dapper;
using mini_bot_api.Interface;
using mini_bot_api.Model;
using System.Data;

namespace mini_bot_api.Dao
{
    public class MiniBotDao:BaseDao, IDao<Answer>
    {
        private readonly IDbTransaction? Transaction;
        private readonly IDbConnection? Connection;

        public MiniBotDao(IDbConnection connection, IDbTransaction? transaction = null)
        {
            Connection = connection;
            Transaction = transaction;
        }

        public List<Answer> FindAll() {
            string commandSql = GetSqlCommand("MiniBotSql", "select");
            List<Answer> objResult = Connection.Query<Answer>(commandSql, commandTimeout:120).ToList();
            return objResult;
        }

        public Answer FindByQuestion(Answer answer)
        {
            string commandSql = GetSqlCommand("MiniBotSql", "selectByQuestion");
            Answer objResult = Connection.QuerySingleOrDefault<Answer>(commandSql, new { replace = answer.question }, commandTimeout: 120);
            return objResult;
        }
        public Answer? FindById(Int64 id)
        {
            return new Answer();
        }
        public void Insert(Answer Instancia)
        {
            string commandSql = GetSqlCommand("MiniBotSql", "insert");
            Int64 chack = Connection.Query(commandSql, Instancia, this.Transaction, commandTimeout: 120).SingleOrDefault();
        }
        public void Update(Answer Instancia) { }
        public void Delete(Answer Instancia) { }
    }
}
