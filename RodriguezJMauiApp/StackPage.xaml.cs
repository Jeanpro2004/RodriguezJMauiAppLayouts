using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls;

namespace RodriguezJMauiApp;

public partial class StackPage : ContentPage
{
    public StackPage()
    {
        InitializeComponent();
    }

    private async void OnGoToFlexClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new FlexPage());
    }
}




