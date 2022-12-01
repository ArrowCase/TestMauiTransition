namespace TestMauiTransition
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnButtonClicked(object sender, EventArgs e)
        {
            Page firstPage = App.Current.MainPage.Navigation.NavigationStack[^1];
            await App.Current.MainPage.Navigation.PushAsync(new SecondPage(), animated: false);
            App.Current.MainPage.Navigation.RemovePage(firstPage);
        }
    }
}
