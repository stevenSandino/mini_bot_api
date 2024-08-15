namespace mini_bot_api.Model
{
    public class Answer
    {
        public string answer { get; set; } = string.Empty;
        public string question { get; set; } = string.Empty;

        public Answer() {
            answer = string.Empty;
            question = string.Empty;
        }

        public Answer(string answer, string question)
        {
            this.answer = answer;
            this.question = question;
        }
    }
}
