﻿namespace TestMauiTransition
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnButtonClicked(object sender, EventArgs e)
        {
            await App.Current?.MainPage?.Navigation?.PushAsync(new SecondPage(), animated: false);
        }

        private async void OnListButtonClicked(object sender, EventArgs e)
        {
            var page = new ListPage();
            page.BindingContext = new MainVM();
            await App.Current?.MainPage?.Navigation?.PushAsync(page, animated: false);
        }
    }
}
