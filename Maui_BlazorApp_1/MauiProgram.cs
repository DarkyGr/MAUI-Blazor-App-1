using Microsoft.Extensions.Logging;
using Maui_BlazorApp_1.Data;
using Maui_BlazorApp_1.Services;

namespace Maui_BlazorApp_1;

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
		
		// Adding injects
		builder.Services.AddSingleton<IRickAndMorty, RickAndMortyService>();

		builder.Services.AddSingleton<WeatherForecastService>();

		return builder.Build();
	}
}
