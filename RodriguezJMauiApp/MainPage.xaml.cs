using System;
using Microsoft.Maui.Controls;

namespace RodriguezJMauiApp
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }

        private async void OnGoToGridClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new GridPage());
        }

        private async void OnGoToStackClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new StackPage());
        }

        private async void OnGoToFlexClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FlexPage());
        }

        private async void OnGoToAbsoluteClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AbsolutePage());
        }
    }
}
