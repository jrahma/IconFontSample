using Microsoft.Extensions.Logging;

namespace IconFontSample;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
                fonts.AddFont("FontAwesomeRegular.otf", "FontRegular");
                fonts.AddFont("FontAwesomeBrands.otf", "FontBrands");
                fonts.AddFont("FontAwesomeSolid.otf", "FontSolid");
                fonts.AddFont("Marhey-Bold.ttf", "MarheyBold");
                fonts.AddFont("Marhey-Light.ttf", "MarheyLight");
                fonts.AddFont("Marhey-Medium.ttf", "MarheyMedium");
                fonts.AddFont("Marhey-SemiBold.ttf", "MarheySemiBold");
                fonts.AddFont("Marhey-Regular.ttf", "MarheyRegular");
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}

