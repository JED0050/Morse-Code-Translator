using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MorseCodeTanslator.ViewModel
{
    public abstract class BaseViewModel : INotifyPropertyChanged
    {
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
