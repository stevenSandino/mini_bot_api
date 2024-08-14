namespace mini_bot_api
{
    public class MiniBot
    {
        private string hello = "Hi my name is Mini Bot, How can I help you";

        public string getAnswer(string question)
        {
            string answer = hello;
            if (question != "")
            {
                switch (question)
                {
                    case "what is your name":
                        answer = "My name is Mini Bot, nice to meet you!";
                        break;
                    default:
                        answer = "I dont have an answer for this, sorry!";
                        break;
                }

            }
            return answer;
        }
    }
}
