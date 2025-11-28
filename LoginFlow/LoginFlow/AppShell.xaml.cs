using LoginFlow.Login;

namespace LoginFlow
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(LoginPage), typeof(LoginPage));
            Routing.RegisterRoute(nameof(InitialisePage), typeof(InitialisePage));
            Routing.RegisterRoute(nameof(MainPage), typeof(MainPage));
        }
    }
}
