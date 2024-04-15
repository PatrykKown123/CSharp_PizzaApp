using FinalPizzaProject.BusinessLogic;

namespace FinalPizzaProject.ProjectUI;

public partial class SummaryPage : ContentPage
{
    Customer pushedCustomerData = new Customer();

    public SummaryPage()
	{
		InitializeComponent();
	}
    public SummaryPage(Customer pushedCustomerData)
    {
        InitializeComponent();
        this.pushedCustomerData = pushedCustomerData;
    }
}