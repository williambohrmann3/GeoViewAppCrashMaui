namespace GeoViewAppCrashMaui
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void SceneViewButton_Clicked(object sender, EventArgs e)
        {
            _ = Shell.Current.Navigation.PushAsync(new GenericPage());
        }
    }

}
