using System.Collections.Generic;

namespace ExpertSystem
{
    public class FactRepository
    {
        public List<Fact> Facts;
        IEnumerator<Fact> Enumerator { get; }   //Get iterator
        public FactRepository()
        {
            Facts = new List<Fact>();
        }
        public void AddFact(Fact fact)
        {
            Facts.Add(fact);
        }
    }
}