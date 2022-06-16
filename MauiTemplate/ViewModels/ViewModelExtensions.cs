namespace MauiTemplate.ViewModels;

public static class ViewModelExtensions
{
    public static MauiAppBuilder ConfigureViewModels(this MauiAppBuilder builder)
    {
        // main page
        builder.Services.AddSingleton<DiscoverViewModel>();
        builder.Services.AddSingleton<EpisodeViewModel>();
        builder.Services.AddSingleton<SettingsViewModel>();
        builder.Services.AddSingleton<ShellViewModel>();
        builder.Services.AddSingleton<ShowViewModel>();

        //navi page
        //builder.Services.AddTransient<ShowDetailViewModel>();
        //builder.Services.AddTransient<EpisodeDetailViewModel>();
        //builder.Services.AddTransient<CategoryViewModel>();

        return builder;
    }
}
