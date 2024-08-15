using mini_bot_api.Model;

namespace mini_bot_api.Interface
{
    public interface IMiniBotService
    {
        List<Answer> GetAnswers();
        void InsertAnswer(Answer answer);
        Answer FindByQuestion(Answer answer);
    }
}
