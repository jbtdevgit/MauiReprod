using Microsoft.Extensions.Logging;
using MVU_test.ViewModels;
using MVU_test.Views;

namespace MVU_test
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .RegisterViews()
                .RegisterViewModels()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
            builder.Logging.AddDebug();
#endif

            

            return builder.Build();
        }

        public static MauiAppBuilder RegisterViews(this MauiAppBuilder mauiAppBuilder)
        {
            mauiAppBuilder.Services.AddTransient<NewPage1>();
            mauiAppBuilder.Services.AddTransient<NewPage2>();
            return mauiAppBuilder;
        }

        public static MauiAppBuilder RegisterViewModels(this MauiAppBuilder mauiAppBuilder)
        {
            mauiAppBuilder.Services.AddTransient<NewPage1ViewModel>();
            mauiAppBuilder.Services.AddTransient<NewPage2ViewModel>();
            return mauiAppBuilder;
        }
    }
}
