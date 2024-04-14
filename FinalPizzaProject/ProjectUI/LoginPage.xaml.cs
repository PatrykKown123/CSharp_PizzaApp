using FinalPizzaProject.DataLayer;
using Microsoft.Maui.ApplicationModel.Communication;

namespace FinalPizzaProject.ProjectUI;

public partial class LoginPage : ContentPage
{

    DataManager manager = new DataManager();
    public LoginPage()
	{
		InitializeComponent();
	}

    private async void login_Clicked(object sender, EventArgs e)
    {
        bool isInJson = false;
        manager.ReadFromFile();
            for (int i = 0; i < DataManager.customerDataBase.Count; i++)
            {
                if (DataManager.customerDataBase[i].CustomerEmail.Equals(username.Text.ToString()) && (DataManager.customerDataBase[i].CustomerPassword.Equals(password.Text.ToString())))
                {
                    isInJson = true;
                    await Navigation.PushAsync(new ItemOptions());
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