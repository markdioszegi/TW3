using System.Xml;

namespace ExpertSystem
{
    public class FactParser : XMLParser
    {
        public FactRepository FactRepository { get; private set; }
        public FactParser(string path)
        {
            FactRepository = new FactRepository();
            LoadXMLDocument(path);
        }

        public override void LoadXMLDocument(string path)
        {
            XmlDocument xml = new XmlDocument();
            xml.Load(path);
            //System.Console.WriteLine(xml.DocumentElement.ChildNodes[0].Name);
            foreach (XmlNode node in xml.DocumentElement)
            {
                string id = node.Attributes[0].Value;
                string description = node.ChildNodes[0].Attributes[0].InnerText;
                string money = node.ChildNodes[1].ChildNodes[0].InnerText;
                string service = node.ChildNodes[1].ChildNodes[1].InnerText;
                string luxury = node.ChildNodes[1].ChildNodes[2].InnerText;

                Fact fact = new Fact(id, description, money, service, luxury);

                FactRepository.AddFact(fact);
            }
        }
    }
}