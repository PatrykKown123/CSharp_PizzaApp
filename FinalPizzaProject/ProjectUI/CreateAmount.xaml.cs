using FinalPizzaProject.BusinessLogic;
using FinalPizzaProject.DataLayer;

namespace FinalPizzaProject.ProjectUI;

public partial class CreateAmount : ContentPage
{
	DataManager customerInfoManager = new DataManager();
	public CreateAmount()
	{
		InitializeComponent();
	}

    private void createAccount_Clicked(object sender, EventArgs e)
    {

		//DataManager.customerDataBase.Add(newCustomer);	

		customerInfoManager.WriteToFile(new Customer()
        {
            CustomerName = firstname.Text + " , " + surname.Text,
            CustomerEmail = email.Text,
            CustomerLocation = address.Text,
            CustomerPhoneNumber = phonenumber.Text,
            CustomerPassword = password.Text
        });	

		Navigation.PushAsync(new WelcomeLandingPage());
    }
}