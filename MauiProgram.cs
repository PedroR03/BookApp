using Microsoft.Extensions.Logging;
using BookApp1.ViewModels;
using BookApp1.Views;
using Microsoft.Maui.Hosting;

namespace BookApp1;

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
			.RegisterPages();

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}

    public static MauiAppBuilder RegisterPages(this MauiAppBuilder muaiAppBuilder)
    {
        //Pages
        muaiAppBuilder.Services.AddSingleton<LogIn>();
        muaiAppBuilder.Services.AddSingleton<MainPage>();
        muaiAppBuilder.Services.AddSingleton<RegisterPage>();
        muaiAppBuilder.Services.AddTransient<DetailsBookPage>();
        muaiAppBuilder.Services.AddTransient<AuthorsPage>();


        //Services
        muaiAppBuilder.Services.AddSingleton<LoginViewModel>();
        muaiAppBuilder.Services.AddSingleton<MainPageViewModel>();
        muaiAppBuilder.Services.AddSingleton<RegisterPageViewModel>();
        muaiAppBuilder.Services.AddTransient<DetailsBookPageViewModel>();
        muaiAppBuilder.Services.AddTransient<AuthorsPageViewModel>();

        return muaiAppBuilder;
    }
}
