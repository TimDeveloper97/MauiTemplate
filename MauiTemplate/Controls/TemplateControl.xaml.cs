using System.Windows.Input;

namespace MauiTemplate.Controls;

public partial class TemplateControl : ContentView
{
    public static readonly BindableProperty SearchCommandProperty =
        BindableProperty.Create(
            nameof(SearchCommand),
            typeof(ICommand),
            typeof(TemplateControl),
            null);

    public static readonly BindableProperty TextToSearchProperty =
        BindableProperty.Create(
            nameof(TextToSearch),
            typeof(string),
            typeof(TemplateControl),
            string.Empty);

    public static readonly BindableProperty ShowSearchCategoriesProperty =
        BindableProperty.Create(
            nameof(ShowSearchCategories),
            typeof(bool),
            typeof(TemplateControl),
            true);

    public bool ShowSearchCategories
    {
        get { return (bool)GetValue(ShowSearchCategoriesProperty); }
        set { SetValue(ShowSearchCategoriesProperty, value); }
    }

    public ICommand SearchCommand
    {
        get { return (ICommand)GetValue(SearchCommandProperty); }
        set { SetValue(SearchCommandProperty, value); }
    }

    public string TextToSearch
    {
        get { return (string)GetValue(TextToSearchProperty); }
        set { SetValue(TextToSearchProperty, value); }
    }

    public TemplateControl()
    {
        AutomationProperties.SetIsInAccessibleTree(this, true);
        InitializeComponent();
    }

    private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
    {
        //await Shell.Current.GoToAsync($"{nameof(CategoriesPage)}");
        await Shell.Current.DisplayAlert("Message", "TapGestureRecognizer_Tapped", "Cancel");
    }
}