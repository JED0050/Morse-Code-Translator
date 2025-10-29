using System.Xml.Linq;

namespace MorseCodeTanslator.Model
{
    public class TranslatorModel : ITranslatorModel
    {
        private readonly Dictionary<char, string> morseMap = new Dictionary<char, string>();

        public TranslatorModel()
        {
            InitMap();
        }

        private void InitMap()
        {
            var doc = XDocument.Load("MorseCode.xml");

            foreach (var code in doc.Root.Elements("Code"))
            {
                char character = code.Attribute("Character").Value[0];
                string value = code.Attribute("Value").Value;
                morseMap[character] = value;
            }
        }

        public string CodeMorse(string plainText)
        {
            List<string> morseCode = new List<string>();

            foreach (char c in plainText.ToUpper())
            {
                if (morseMap.TryGetValue(c, out string val))
                    morseCode.Add(val);
                else
                    morseCode.Add("??");
            }

            return string.Join(" ", morseCode);
        }

        public string DecodeMorse(string morseCode)
        {
            throw new NotImplementedException();
        }
    }
}
