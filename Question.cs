namespace ExpertSystem
{
    public class Question
    {
        public string ID { get; private set; }  //GetID here
        public string _Question { get; private set; }

        public Answer Answer { get; private set; }

        public Question(string id, string question, Answer answer)
        {
            ID = id;
            _Question = question;
            Answer = answer;
        }
        public bool GetEvaluatedAnswer(string input)
        {
            return Answer.EvaluateAnswerByInput(input);
        }
    }
}