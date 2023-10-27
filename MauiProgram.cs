using B312_939_Admin.Data;
using Microsoft.Extensions.Logging;
using Refit;
namespace B312_939_Admin
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
                });

            builder.Services.AddMauiBlazorWebView();

#if DEBUG
		builder.Services.AddBlazorWebViewDeveloperTools();
		builder.Logging.AddDebug();
#endif

            builder.Services.AddSingleton<WeatherForecastService>();
            builder.Services.AddRefitClient<IApiAccess>().ConfigureHttpClient(c => c.BaseAddress = new Uri("http://192.168.254.254/api"));
            return builder.Build();
        }
    }
}