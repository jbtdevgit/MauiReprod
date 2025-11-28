using System.Threading.Tasks;

namespace LoginFlow;

public partial class InitialisePage : ContentPage
{
	public InitialisePage()
	{
		InitializeComponent();
	}

    protected override async void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);
        await Shell.Current.GoToAsync($"//{nameof(MainPage)}");
    }
}