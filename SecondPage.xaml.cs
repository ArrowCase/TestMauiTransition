namespace TestMauiTransition
{
    public partial class SecondPage : ContentPage
    {
        public SecondPage()
        {
            InitializeComponent();
        }

        private async void OnButtonClicked(object sender, EventArgs e)
        {
            await App.Current?.MainPage?.Navigation?.PopAsync(animated: false);
        }
    }
}
