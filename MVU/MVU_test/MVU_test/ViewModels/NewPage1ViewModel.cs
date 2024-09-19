using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MVU_test.Views;

namespace MVU_test.ViewModels
{
    public partial class NewPage1ViewModel : ObservableObject
    {
        int ctr;

        public NewPage1ViewModel()
        {
            ctr = 0;
            Counter = $"{ctr}";
        }

        [ObservableProperty]
        private string counter;

        [RelayCommand]
        private async Task Increment()
        {
            Counter = $"{ctr++}";

            if (ctr > 5)
            {
                GC.Collect();
                await Shell.Current.GoToAsync(nameof(NewPage2));
            }
        }
    }
}
