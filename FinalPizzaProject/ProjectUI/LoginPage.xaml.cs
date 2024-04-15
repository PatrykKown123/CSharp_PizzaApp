using FinalPizzaProject.BusinessLogic;
using FinalPizzaProject.DataLayer;
using Microsoft.Maui.ApplicationModel.Communication;

namespace FinalPizzaProject.ProjectUI;

public partial class LoginPage : ContentPage
{

    DataManager manager = new DataManager();

    Customer pushedCustomerData = new Customer();
    public LoginPage()
	{
		InitializeComponent();
       CreateAmount.customerDatabase = manager.PopulateList();
    }

    private async void login_Clicked(object sender, EventArgs e)
    {
            bool isInJson = false;
        //CreateAmount.customerDatabase = manager.PopulateList();
        for (int i = 0; i < CreateAmount.customerDatabase.Count; i++)
            {
                if (CreateAmount.customerDatabase[i].CustomerEmail.Equals(username.Text.ToString()) && (CreateAmount.customerDatabase[i].CustomerPassword.Equals(password.Text.ToString())))
                {
                    isInJson = true;
                    pushedCustomerData = CreateAmount.customerDatabase[i];
                    await Navigation.PushAsync(new ItemOptions(pushedCustomerData));
                }
            }

            if (isInJson == false) {
                await DisplayAlert("ERROR!", "The account does not exist", "OK");
            }
         
        
/*
        for (int i = 0; i < DataManager.customerDataBase.Count; i++)
        {
            DisplayAlert("TEST", $"LIST SIZE: {DataManager.customerDataBase[i].CustomerEmail}", "ok");
        }*/

  
        //} catch (Exception ex)
        //{
          //  await DisplayAlert("ERROR", $"{ex.Message}","OK");
        //}
    }

    private void signup_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new CreateAmount());
    }
}