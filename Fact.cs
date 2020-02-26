namespace ExpertSystem
{
    public class Fact
    {
        public string ID { get; private set; }
        public string Description { get; private set; }     //getDescription here
        public string Money { get; private set; }     //getDescription here
        public string Service { get; private set; }     //getDescription here
        public string Luxury { get; private set; }     //getDescription here

        public Fact(string id, string description, string money, string service, string luxury)
        {
            ID = id;
            Description = description;
            Money = money;
            Service = service;
            Luxury = luxury;
        }
    }
}