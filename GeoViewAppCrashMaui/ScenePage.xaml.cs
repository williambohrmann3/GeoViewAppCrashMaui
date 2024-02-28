using Esri.ArcGISRuntime.Mapping;

namespace GeoViewAppCrashMaui
{
    public partial class ScenePage : ContentPage
    {
        public ScenePage()
        {
            InitializeComponent();

            // Create a new Scene
            MySceneView.Scene = new Scene(BasemapStyle.OSMStreets);
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            ToolbarItems.Add(new ToolbarItem() { Text = "item added via code-behind" });
        }
    }

}
