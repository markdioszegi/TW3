using System.Collections.Generic;

namespace ExpertSystem
{
    public class MultipleValue : Value
    {
        List<string> Params { get; }
        bool SelectionType { get; }
        public MultipleValue(List<string> _params, bool selectionType)
        {
            Params = _params;
            SelectionType = selectionType;
        }

        public override List<string> GetInputPattern()
        {
            throw new System.NotImplementedException();
        }

        public override bool GetSelectionType()
        {
            throw new System.NotImplementedException();
        }

    }
}