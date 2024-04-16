using FinalPizzaProject.BusinessLogic;

namespace FinalPizzaProject.ProjectUI;

public partial class SummaryPage : ContentPage
{
    Customer pushedCustomerData = new Customer();
    Pizza newPizza = new Pizza();   
    double totalCost = 0;   
    public SummaryPage()
	{
		InitializeComponent();
        BindingContext = pushedCustomerData;
    }
    public SummaryPage(Customer pushedCustomerData)
    {
        InitializeComponent();
        this.pushedCustomerData = pushedCustomerData;
        BindingContext = pushedCustomerData;
    }

    public SummaryPage(Customer pushedCustomerData,Pizza newPizza)
    {
        InitializeComponent();
        this.pushedCustomerData = pushedCustomerData;
        this.newPizza = newPizza;
        BindingContext = pushedCustomerData;
        //BindingContext = newPizza;
    }
}