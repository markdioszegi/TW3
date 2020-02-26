using System;
using System.Collections.Generic;

namespace ExpertSystem
{
    public class ESProvider
    {
        FactRepository FactRepository;
        RuleRepository RuleRepository;
        public FactParser FactParser { get; private set; }
        public RuleParser RuleParser { get; private set; }

        Dictionary<string, bool> Answers;

        IEnumerator<Question> QuestionEnumerator;
        IEnumerator<Fact> FactEnumerator;
        readonly string errorMessage;
        public ESProvider(FactParser factParser, RuleParser ruleParser)
        {
            FactParser = factParser;
            RuleParser = ruleParser;
            FactRepository = FactParser.FactRepository;
            RuleRepository = RuleParser.RuleRepository;
            Answers = new Dictionary<string, bool>();
            errorMessage = "shit happens.";
        }
        public void CollectAnswers()
        {
            QuestionEnumerator = RuleRepository._questionEnumerator;
            while (QuestionEnumerator.MoveNext())
            {
                Question question = QuestionEnumerator.Current;
                Console.WriteLine(question._Question);
                string answer = Console.ReadLine();
                Answers.Add(question.ID, question.GetEvaluatedAnswer(answer));
            }
        }
        public bool GetAnswerByQuestion(string questionID)
        {
            return Answers[questionID];
        }
        public string Evaluate()
        {
            FactEnumerator = FactRepository._factEnumerator;

            while (FactEnumerator.MoveNext())
            {
                Fact fact = FactEnumerator.Current;
                int sum = 0;

                foreach (KeyValuePair<string, bool> answer in Answers)
                {
                    bool field = Convert.ToBoolean(fact.GetType().GetProperty(answer.Key).GetValue(fact, null));
                    if (answer.Value == field)
                    {
                        sum++;
                        if (sum == Answers.Count)
                        {
                            return fact.Description;
                        }
                    }
                    else
                    {
                        continue;
                    }
                }
            }

            return errorMessage;
        }
    }
}