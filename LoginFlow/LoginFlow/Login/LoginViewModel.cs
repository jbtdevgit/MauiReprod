using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace LoginFlow.Login
{
    public sealed partial class LoginViewModel : ObservableRecipient
    {
        public LoginViewModel()
        {
            
        }

        [ObservableProperty]
        private bool isNameValid;

        [ObservableProperty]
        private string name;

        [RelayCommand]
        private async Task LoginAsync()
        {
            if (!IsNameValid)
            {
                return;
            }

            // Simulate login process
            await Task.Delay(1000);
            // Navigate to InitialisePage after login
            await Shell.Current.GoToAsync($"{nameof(InitialisePage)}");
        }
    }
}
