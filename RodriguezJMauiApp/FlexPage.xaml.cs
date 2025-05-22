using Microsoft.Maui.Controls;

using Microsoft.Maui.Controls;

namespace RodriguezJMauiApp;

public partial class FlexPage : ContentPage
{
    public FlexPage()
    {
        InitializeComponent();
    }

    private async void OnGoToAbsoluteClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new AbsolutePage());
    }
}


