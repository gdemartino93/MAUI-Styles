namespace MAUI_Styles
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new DynamicStyleDemo();
        }
    }
}
