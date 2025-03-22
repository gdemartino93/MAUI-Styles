namespace MAUI_Styles;

public partial class DynamicStyleDemo : ContentPage
{
	public DynamicStyleDemo()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        //this is resource defined in the DynamicStyleView
       //Resources["customBtn"] = Resources["changedColor"];

        //this use resource defined in the global style resources. ButtonStyle xaml
       if (Application.Current?.Resources.TryGetValue("specialBtn", out var specialBtn) == true)
        {
            Resources["customBtn"] = specialBtn;
        }
    }
}