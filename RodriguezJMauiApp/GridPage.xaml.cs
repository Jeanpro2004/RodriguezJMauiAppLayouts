using Microsoft.Maui.Controls;

using Microsoft.Maui.Controls;

namespace RodriguezJMauiApp;

public partial class GridPage : ContentPage
{
    public GridPage()
    {
        InitializeComponent();
    }

    private async void OnGoToStackClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new StackPage());
    }
}


