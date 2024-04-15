using FinalPizzaProject.BusinessLogic;

namespace FinalPizzaProject.ProjectUI;

public partial class WelcomeLandingPage : ContentPage
{

    Customer pushedCustomerData = new Customer();
    public WelcomeLandingPage()
	{
		InitializeComponent();
        BindingContext = pushedCustomerData;
    }

    public WelcomeLandingPage(Customer pushedCustomerData) {
        InitializeComponent();
        this.pushedCustomerData = pushedCustomerData;
        BindingContext = pushedCustomerData;
    }

    private void ordernow_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new ItemOptions(pushedCustomerData));
    }

    private void continue_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new ItemOptions(pushedCustomerData));
    }
}