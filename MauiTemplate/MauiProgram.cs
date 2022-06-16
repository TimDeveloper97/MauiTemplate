namespace MauiTemplate;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
            .ConfigureEssentials()
            .ConfigureServices()
            .ConfigurePages()
            .ConfigureViewModels()
            .ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
				fonts.AddFont("Segoe-Ui-Bold.ttf", "SegoeUiBold");
				fonts.AddFont("Segoe-Ui-Regular.ttf", "SegoeUiRegular");
				fonts.AddFont("Segoe-Ui-Semibold.ttf", "SegoeUiSemibold");
				fonts.AddFont("Segoe-Ui-Semilight.ttf", "SegoeUiSemilight");
			});

		return builder.Build();
	}
}
