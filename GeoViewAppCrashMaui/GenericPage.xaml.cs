namespace GeoViewAppCrashMaui
{
    public partial class GenericPage : ContentPage
    {
        public GenericPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            ToolbarItems.Add(new ToolbarItem() { Text = "item added via code-behind" });
        }
    }

}
