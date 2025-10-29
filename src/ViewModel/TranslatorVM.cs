using MorseCodeTanslator.Model;
using System.ComponentModel;

namespace MorseCodeTanslator.ViewModel
{
    public class TranslatorVM : BaseViewModel
    {
        private readonly ITranslatorModel translatorModel;

        private string textLeft;
        public string TextLeft
        {
            get => textLeft;
            set
            {
                textLeft = value;
                OnPropertyChanged();
            }
        }

        private string textRight;

        public string TextRight
        {
            get => textRight;
            set
            {
                textRight = value;
                OnPropertyChanged();
            }
        }
        
        public TranslatorVM(ITranslatorModel translatorModel)
        {
            this.translatorModel = translatorModel;

            PropertyChanged += TranslatorVM_PropertyChanged;

            TextLeft = "Hello Marcin!";
        }

        private void TranslatorVM_PropertyChanged(object? sender, PropertyChangedEventArgs e)
        {
            if (nameof(TextLeft) == e.PropertyName)
                TextRight = translatorModel.CodeMorse(TextLeft);
        }
    }
}
