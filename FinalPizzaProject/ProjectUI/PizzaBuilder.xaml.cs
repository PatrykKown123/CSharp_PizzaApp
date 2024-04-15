using FinalPizzaProject.BusinessLogic;

namespace FinalPizzaProject.ProjectUI;

public partial class PizzaBuilder : ContentPage
{
    List<CheckBox> checkboxes = new List<CheckBox>();
    Dictionary<CheckBox, Image> toppingsDictionary = new Dictionary<CheckBox, Image>();
    Customer pushedCustomerData = new Customer();
    Image pepperoniImage = new Image()
    {
        Source = "pepperoni.png",
        WidthRequest = 300
    };
    Image pepperImage = new Image()
    {
        Source = "pepper.png",
        WidthRequest = 300
    };
    Image pineappleImage = new Image()
    {
        Source = "pineapples.png",
        WidthRequest = 300
    };
    Image mushroomImage = new Image()
    {
        Source = "mushrooms.png",
        WidthRequest = 300
    };
    Image olivesImage = new Image()
    {
        Source = "olives.png",
        WidthRequest = 300
    };
    Image onionsImage = new Image()
    {
        Source = "onions.png",
        WidthRequest = 300
    };
    Image baconImage = new Image()
    {
        Source = "bacon.png",
        WidthRequest = 300
    };
    public PizzaBuilder()
	{
		InitializeComponent();
        toppingsDictionary.Add(pepperoni, pepperoniImage);
        toppingsDictionary.Add(peppers, pepperImage);
        toppingsDictionary.Add(pineapple, pineappleImage);
        toppingsDictionary.Add(mushrooms, mushroomImage);
        toppingsDictionary.Add(olives, olivesImage);
        toppingsDictionary.Add(onions, onionsImage);
        toppingsDictionary.Add(bacon, baconImage);

        BindingContext = pushedCustomerData;
    }

    public PizzaBuilder(Customer pushedCustomerData)
    {
        InitializeComponent();
        this.pushedCustomerData = pushedCustomerData;
        toppingsDictionary.Add(pepperoni, pepperoniImage);
        toppingsDictionary.Add(peppers, pepperImage);
        toppingsDictionary.Add(pineapple, pineappleImage);
        toppingsDictionary.Add(mushrooms, mushroomImage);
        toppingsDictionary.Add(olives, olivesImage);
        toppingsDictionary.Add(onions, onionsImage);
        toppingsDictionary.Add(bacon, baconImage);

        BindingContext = pushedCustomerData;
    }

    public void CheckBox_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        if (sender is CheckBox checkBox)
        {
            if (checkBox.IsChecked)
            {
                if (toppingsDictionary.ContainsKey(checkBox))
                {
                    Image toppingImage = toppingsDictionary[checkBox];
                    pizzaBuilder.Children.Add(toppingImage);
                }
            }
            else
            {
                if (toppingsDictionary.ContainsKey(checkBox))
                {
                    Image toppingImage = toppingsDictionary[checkBox];
                    pizzaBuilder.Children.Remove(toppingImage);
                }
            }
        }
    }


    private void continueOn_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new SummaryPage(pushedCustomerData));
    }
}