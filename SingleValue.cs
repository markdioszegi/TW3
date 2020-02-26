using System.Collections.Generic;

namespace ExpertSystem
{
    public class SingleValue : Value
    {
        public SingleValue(List<string> param, bool selectionType)
        {
            InputPattern = param;
            SelectionType = selectionType;
        }
    }
}