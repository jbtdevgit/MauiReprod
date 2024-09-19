using MVU_test.ViewModels;

namespace MVU_test.Views;

public class NewPage2 : ContentPage
{
    private readonly NewPage2ViewModel ViewModel;
	public NewPage2(NewPage2ViewModel viewModel)
	{
		BindingContext = viewModel;
        ViewModel = viewModel;
        Render();
	}

	private void Render()
	{
        Content = new VerticalStackLayout
        {
            Children = {
                GoBackButton()
            }
        };
    }

    private Button GoBackButton()
    {
        return new()
        {
            HorizontalOptions = LayoutOptions.Center,
            VerticalOptions = LayoutOptions.Center,
            Command = ViewModel?.GoBackCommand,
            Text = "Go Back"
        };
    }
}