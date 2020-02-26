using System;
using System.IO;

namespace ExpertSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            FactParser factParser = new FactParser("facts.xml");
            RuleParser ruleParser = new RuleParser("rules.xml");
            ESProvider provider = new ESProvider(factParser, ruleParser);

            /* foreach (var fact in factParser.FactRepository.Facts)
            {
                System.Console.WriteLine(fact.Description);
            } */

            provider.CollectAnswers();
            Console.Write("Enter an ID: ");
            Console.WriteLine(provider.GetAnswerByQuestion(Console.ReadLine()));
            Console.WriteLine(provider.Evaluate());
        }
    }
}
