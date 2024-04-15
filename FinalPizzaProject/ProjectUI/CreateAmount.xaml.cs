using FinalPizzaProject.BusinessLogic;
using FinalPizzaProject.DataLayer;

namespace FinalPizzaProject.ProjectUI;

public partial class CreateAmount : ContentPage
{
	DataManager customerInfoManager = new DataManager();
    public static List<Customer> customerDatabase = new List<Customer>();
    Customer pushedCustomerData = new Customer();

	public CreateAmount()
	{
		InitializeComponent();

    }

    private void createAccount_Clicked(object sender, EventArgs e)
    {
        //DataManager.customerDataBase.Add(newCustomer);	
        pushedCustomerData = new Customer() {
            CustomerName = firstname.Text + " , " + surname.Text,
            CustomerEmail = email.Text,
            CustomerLocation = address.Text,
            CustomerPhoneNumber = phonenumber.Text,
            CustomerPassword = password.Text
        };
        customerInfoManager.WriteToFile(pushedCustomerData, customerDatabase);
        Navigation.PushAsync(new WelcomeLandingPage(pushedCustomerData));
    }
}