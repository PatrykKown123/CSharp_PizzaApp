using FinalPizzaProject.BusinessLogic;

namespace FinalPizzaProject.ProjectUI;

public partial class ItemOptions : ContentPage
{
    Customer pushedCustomerData = new Customer();
    public ItemOptions()
	{
		InitializeComponent();
        BindingContext = pushedCustomerData;

    }
    public ItemOptions(Customer pushedCustomerData) {
		InitializeComponent();
		this.pushedCustomerData = pushedCustomerData;
        BindingContext = pushedCustomerData;
    }
    private void continue_Clicked(object sender, EventArgs e)
    {
		if (pizzaCheck.IsChecked)
		{
			Navigation.PushAsync(new PizzaBuilder(pushedCustomerData));
		}
		else 
		{
			Navigation.PushAsync(new SummaryPage(pushedCustomerData));
		}
    }
}