using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ExpertSystem
{
    public class RuleRepository
    {
        Dictionary<string, Question> Questions;
        public IEnumerator<Question> _questionEnumerator { get; }     //Get iterator
        public RuleRepository()
        {
            Questions = new Dictionary<string, Question>();
            _questionEnumerator = new QuestionEnumerator(Questions);
        }
        public void AddQuestion(Question question)
        {
            Questions.Add(question.ID, question);
        }

        private class QuestionEnumerator : IEnumerator<Question>
        {
            int currentIndex;
            string currentKey;
            Dictionary<string, Question> questions;
            public QuestionEnumerator(Dictionary<string, Question> questions)
            {
                Reset();
                this.questions = questions;
                currentKey = default;
            }
            public object Current => Current;
            Question IEnumerator<Question>.Current => questions[currentKey];

            public void Dispose() { }

            public bool MoveNext()
            {
                if (questions.Count <= ++currentIndex)
                {
                    return false;
                }
                else
                {
                    currentKey = questions.ElementAt(currentIndex).Key;
                }

                return true;
            }

            public void Reset()
            {
                currentIndex = -1;
            }
        }
    }
}