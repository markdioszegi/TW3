using System.Collections.Generic;

namespace ExpertSystem
{
    public class SingleValue : Value
    {
        string Param { get; }
        bool SelectionType { get; }
        public SingleValue(string param, bool selectionType)
        {
            Param = param;
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