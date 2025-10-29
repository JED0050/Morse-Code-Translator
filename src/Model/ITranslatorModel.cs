namespace MorseCodeTanslator.Model
{
    public interface ITranslatorModel
    {
        string CodeMorse(string plainText);
        string DecodeMorse(string morseCode);
    }
}
