using Microsoft.Maui.Controls;

using Microsoft.Maui.Controls;

namespace RodriguezJMauiApp;

public partial class AbsolutePage : ContentPage
{
    public AbsolutePage()
    {
        InitializeComponent();
    }

    private async void OnGoToGridClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new GridPage());
    }
}

