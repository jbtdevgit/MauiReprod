using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MVU_test.ViewModels
{
    public partial class NewPage2ViewModel : ObservableObject
    {
        public NewPage2ViewModel()
        {
            
        }

        [RelayCommand]
        private async Task GoBackAsync()
        {
            await Shell.Current.GoToAsync("..");
        }
    }
}
