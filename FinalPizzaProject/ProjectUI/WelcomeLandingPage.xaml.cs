namespace FinalPizzaProject.ProjectUI;

public partial class WelcomeLandingPage : ContentPage
{
	public WelcomeLandingPage()
	{
		InitializeComponent();
	}

    private void ordernow_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new ItemOptions());
    }

    private void continue_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new ItemOptions());
    }
}