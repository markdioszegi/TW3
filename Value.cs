using System.Collections.Generic;

namespace ExpertSystem
{
    public abstract class Value
    {
        public abstract List<string> GetInputPattern();
        public abstract bool GetSelectionType();
    }
}