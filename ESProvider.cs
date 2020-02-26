namespace ExpertSystem
{
    public class ESProvider
    {
        FactRepository FactRepository;
        RuleRepository RuleRepository;
        public FactParser FactParser { get; set; }
        public RuleParser RuleParser { get; set; }
        public ESProvider(FactParser factParser, RuleParser ruleParser)
        {
            FactParser = factParser;
            RuleParser = ruleParser;
            FactRepository = FactParser.FactRepository;
            //RuleRepository = RuleParser.RuleRepository;
        }
        public void CollectAnswers()
        {

        }
        public bool GetAnswerByQuestion(string questionID)
        {
            return false;
        }
        public string Evaluate()
        {
            return "No fact found.";
        }
    }
}