using MVU_test.Views;

namespace MVU_test
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(NewPage2), typeof(NewPage2));
        }
    }
}
