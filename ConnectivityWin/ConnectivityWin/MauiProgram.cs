using ConnectivityWin.Services;
using Microsoft.Extensions.Logging;
using Microsoft.Maui.LifecycleEvents;

namespace ConnectivityWin
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                })
                .ConfigureLifecycleEvents(events =>
                {
#if WINDOWS
                    events.AddWindows(windows => windows
                    .OnLaunched((window, args) => InitialiseConnectivityEvent())
                    .OnClosed((window, args) => UnregisterConnectivityEvent())
                    );
#endif

                    static void InitialiseConnectivityEvent()
                    {
                        IConnectivityService service = Application.Current.Handler.MauiContext.Services.GetService<IConnectivityService>();
                        service?.InitialiseConnectivity();
                    }

                    static void UnregisterConnectivityEvent()
                    {
                        Application.Current.Handler.MauiContext.Services.GetService<IConnectivityService>()?.StopConnectivity();
                    }

                });

#if DEBUG
		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}