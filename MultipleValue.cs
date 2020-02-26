using System.Collections.Generic;

namespace ExpertSystem
{
    public class MultipleValue : Value
    {
        public MultipleValue(List<string> inputPattern, bool selectionType)
        {
            InputPattern = inputPattern;
            SelectionType = selectionType;
        }
    }
}