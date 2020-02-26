using System;
using System.Collections.Generic;

namespace ExpertSystem
{
    public class Answer
    {
        private List<Value> valuesList;

        public Answer()
        {
            valuesList = new List<Value>();
        }
        public bool EvaluateAnswerByInput(string input)
        {
            foreach (Value value in valuesList)
            {
                if (value.GetType() == typeof(SingleValue))
                {
                    if (value.InputPattern[0] == input)
                    {
                        return value.SelectionType;
                    }
                }
                else if (value.GetType() == typeof(MultipleValue))
                {
                    foreach (string element in value.InputPattern)
                    {
                        if (input == element)
                        {
                            return value.SelectionType;
                        }
                    }
                }
            }
            throw new ArgumentException("Invalid input.");
        }
        public void AddValue(Value value)
        {
            valuesList.Add(value);
        }
    }
}