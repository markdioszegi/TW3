using System.Collections.Generic;

namespace ExpertSystem
{
    public abstract class Value
    {
        public List<string> InputPattern { get; set; }
        public bool SelectionType { get; set; }
    }
}