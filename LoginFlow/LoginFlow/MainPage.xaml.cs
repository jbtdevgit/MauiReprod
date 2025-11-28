using System.Threading.Tasks;

namespace LoginFlow
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnCounterClicked(object? sender, EventArgs e)
        {
            SemanticScreenReader.Announce(CounterBtn.Text);
            await Shell.Current.GoToAsync($"//{nameof(Login)}");
        }
    }
}
