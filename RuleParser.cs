using System.Collections.Generic;
using System.Xml;

namespace ExpertSystem
{
    public class RuleParser : XMLParser
    {
        public RuleRepository RuleRepository { get; private set; }

        public RuleParser(string path)
        {
            RuleRepository = new RuleRepository();
            LoadXMLDocument(path);
        }

        public override void LoadXMLDocument(string path)
        {
            Answer answer = new Answer();
            Value value = null;
            string idPath;
            string questionPath;
            XmlDocument xml = new XmlDocument();
            xml.Load(path);

            foreach (XmlNode node in xml.DocumentElement)
            {
                idPath = node.Attributes[0].Value;
                questionPath = node.ChildNodes[0].InnerText;

                foreach (XmlNode childNode in node.ChildNodes[1])
                {
                    string[] values = childNode.ChildNodes[0].Attributes[0].InnerText.Split(',');
                    List<string> valueList = new List<string>();

                    foreach (string v in values)
                    {
                        valueList.Add(v);
                    }

                    if (values.Length == 1)
                    {
                        value = new SingleValue(valueList, bool.Parse(childNode.Attributes[0].InnerText));   //keep in mind
                    }
                    else if (values.Length > 1)
                    {
                        value = new MultipleValue(valueList, bool.Parse(childNode.Attributes[0].InnerText));
                    }

                    answer.AddValue(value);
                }

                Question question = new Question(idPath, questionPath, answer);
                RuleRepository.AddQuestion(question);
            }
        }
    }
}