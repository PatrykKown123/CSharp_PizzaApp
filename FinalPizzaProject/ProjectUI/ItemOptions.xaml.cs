namespace FinalPizzaProject.ProjectUI;

public partial class ItemOptions : ContentPage
{
	public ItemOptions()
	{
		InitializeComponent();
	}

    private void continue_Clicked(object sender, EventArgs e)
    {
		if (pizzaCheck.IsChecked)
		{
			Navigation.PushAsync(new PizzaBuilder());
		}
		else 
		{
			Navigation.PushAsync(new SummaryPage());
		}
    }
}