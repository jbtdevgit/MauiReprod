using MVU_test.ViewModels;

namespace MVU_test.Views;

public class NewPage1 : ContentPage
{
	private readonly NewPage1ViewModel? ViewModel;

    public NewPage1(NewPage1ViewModel viewModel)
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
                CounterLabel(),
                CounterButton(),
            },
        };
    }

    private Label CounterLabel()
    {
        Label counterLabel = new()
        {
            HorizontalOptions = LayoutOptions.Center,
            VerticalOptions = LayoutOptions.Center,
            TextColor = Color.FromArgb("#FFFFFF"),
        };
        counterLabel.SetBinding(Label.TextProperty, "Counter");
        return counterLabel;
    }

    private Button CounterButton()
    {
        Button counterButton = new()
        {
            HorizontalOptions = LayoutOptions.Center,
            VerticalOptions = LayoutOptions.Center,
            Command = ViewModel?.IncrementCommand,
            Text = "Click"
        };

        return counterButton;
    }
}