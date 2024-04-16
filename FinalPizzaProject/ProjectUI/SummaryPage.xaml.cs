using FinalPizzaProject.BusinessLogic;

namespace FinalPizzaProject.ProjectUI;

public partial class SummaryPage : ContentPage
{
    Customer pushedCustomerData = new Customer();
    Pizza newPizza = new Pizza();
    double totalCost = 20.99;   
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

        baseData.Text = $"Base({newPizza.PizzaBase}, basic cheese, basic sauce, standard size)";
        toppingsListView.ItemsSource = newPizza.PizzaToppings;
        toppingsCost.Text = (newPizza.PizzaToppings.Count * 0.50).ToString("C");
        totalCost += newPizza.PizzaToppings.Count * 0.50;
        tax.Text = (totalCost*0.13).ToString("C");
        deliverFree.Text = 5.ToString("C"); 
        serviceFree.Text = 2.ToString("C");

        totalCost += totalCost * 0.13;
        totalCost += 5;
        totalCost += 2;

        cost.Text = totalCost.ToString("C");    
    }

    private void pizzaQuantity_TextChanged(object sender, TextChangedEventArgs e)
    {
        try
        {

            if (e.NewTextValue.Equals("0"))
            {
                totalCost = 0;
                cost.Text = totalCost.ToString("C");
            }
            else {
                totalCost = 0;
                double calculation = Convert.ToDouble(e.NewTextValue) * 20.99;
                var newText = calculation.ToString("C");
                totalCost += Math.Round(Convert.ToDouble(e.NewTextValue) * 20.99, 2);
                costPerPizza.Text = newText;
                totalCost += Convert.ToDouble(e.NewTextValue) * (newPizza.PizzaToppings.Count * 0.50);
                toppingsCost.Text = (Convert.ToDouble(e.NewTextValue) * (newPizza.PizzaToppings.Count * 0.50)).ToString("C");
                totalCost += totalCost * 0.13;
                totalCost += 5;
                totalCost += 2;
                cost.Text = totalCost.ToString("C");
            }
        }
        catch(Exception) { }
    }
}