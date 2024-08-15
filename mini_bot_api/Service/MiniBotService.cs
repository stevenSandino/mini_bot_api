using mini_bot_api.Dao;
using mini_bot_api.Interface;
using mini_bot_api.Model;

namespace mini_bot_api.Service
{
    public class MiniBotService:IMiniBotService
    {
        private readonly IConnection connectionFac;
        public MiniBotService(IConnection connectionFac)
        {
            this.connectionFac = connectionFac;
        }
        public List<Answer> GetAnswers()
        {
            using var connection = connectionFac.GetConnection();
            MiniBotDao dao = new(connection);
            var data = dao.FindAll();
            return data;
        }
        public void InsertAnswer(Answer answer)
        {
            using var connection = connectionFac.GetConnection();
            MiniBotDao dao = new(connection);
            dao.Insert(answer);
        }
        public Answer FindByQuestion(Answer answer)
        {
            using var connection = connectionFac.GetConnection();
            MiniBotDao dao = new(connection);
            var data = dao.FindByQuestion(answer);
            return data;
        }
    }
}
