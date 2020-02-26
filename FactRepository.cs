using System.Collections;
using System.Collections.Generic;

namespace ExpertSystem
{
    public class FactRepository
    {
        List<Fact> Facts;
        public IEnumerator<Fact> _factEnumerator { get; }   //Get iterator
        public FactRepository()
        {
            Facts = new List<Fact>();
            _factEnumerator = new FactEnumerator(Facts);
        }
        public void AddFact(Fact fact)
        {
            Facts.Add(fact);
        }

        private class FactEnumerator : IEnumerator<Fact>
        {
            int currentIndex;
            List<Fact> facts;

            public FactEnumerator(List<Fact> facts)
            {
                Reset();
                this.facts = facts;
            }

            public object Current => Current;

            Fact IEnumerator<Fact>.Current => facts[currentIndex];

            public void Dispose() { }

            public bool MoveNext()
            {
                if (facts.Count <= ++currentIndex)
                {
                    return false;
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