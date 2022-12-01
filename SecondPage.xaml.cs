namespace TestMauiTransition
{
    public partial class SecondPage : ContentPage
    {
        public SecondPage()
        {
            InitializeComponent();
        }

        private void OnButtonClicked(object sender, EventArgs e)
        {
            App.Current?.MainPage?.Navigation?.PopAsync(animated: false);
        }
    }
}
