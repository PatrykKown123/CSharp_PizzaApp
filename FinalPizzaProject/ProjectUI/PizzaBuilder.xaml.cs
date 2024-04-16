using FinalPizzaProject.BusinessLogic;

namespace FinalPizzaProject.ProjectUI;

public partial class PizzaBuilder : ContentPage
{
    List<CheckBox> checkboxes = new List<CheckBox>();
    Dictionary<CheckBox, Image> toppingsDictionary = new Dictionary<CheckBox, Image>();
    Customer pushedCustomerData = new Customer();
    Pizza newPizza= new Pizza();

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

                    if (toppingsDictionary[checkBox] == pepperoniImage)
                    {
                        newPizza.PizzaToppings.Add(PizzaToppings.Pepperoni);
                    }
                    else if (toppingsDictionary[checkBox] == pepperImage)
                    {
                        newPizza.PizzaToppings.Add(PizzaToppings.Pepper);
                    }
                    else if (toppingsDictionary[checkBox] == pineappleImage)
                    {
                        newPizza.PizzaToppings.Add(PizzaToppings.Pineapple);
                    }
                    else if (toppingsDictionary[checkBox] == mushroomImage)
                    {
                        newPizza.PizzaToppings.Add(PizzaToppings.Mushroom);
                    }
                    else if (toppingsDictionary[checkBox] == olivesImage)
                    {
                        newPizza.PizzaToppings.Add(PizzaToppings.Olives);
                    }
                    else if (toppingsDictionary[checkBox] == onionsImage)
                    {
                        newPizza.PizzaToppings.Add(PizzaToppings.Onion);
                    }
                    else
                    {
                        newPizza.PizzaToppings.Add(PizzaToppings.Bacon);
                    }

                }
            }
            else
            {
                if (toppingsDictionary.ContainsKey(checkBox))
                {
                    Image toppingImage = toppingsDictionary[checkBox];
                    pizzaBuilder.Children.Remove(toppingImage);
                    if (toppingsDictionary[checkBox] == pepperoniImage)
                    {
                        newPizza.PizzaToppings.Remove(PizzaToppings.Pepperoni);
                    }
                    else if (toppingsDictionary[checkBox] == pepperImage)
                    {
                        newPizza.PizzaToppings.Remove(PizzaToppings.Pepper);
                    }
                    else if (toppingsDictionary[checkBox] == pineappleImage)
                    {
                        newPizza.PizzaToppings.Remove(PizzaToppings.Pineapple);
                    }
                    else if (toppingsDictionary[checkBox] == mushroomImage)
                    {
                        newPizza.PizzaToppings.Remove(PizzaToppings.Mushroom);
                    }
                    else if (toppingsDictionary[checkBox] == olivesImage)
                    {
                        newPizza.PizzaToppings.Remove(PizzaToppings.Olives);
                    }
                    else if (toppingsDictionary[checkBox] == onionsImage)
                    {
                        newPizza.PizzaToppings.Remove(PizzaToppings.Onion);
                    }
                    else
                    {
                        newPizza.PizzaToppings.Remove(PizzaToppings.Bacon);
                    }
                }
            }
        }
    }

    public void CheckBox_CheckedChangedPizzaBase(object sender, CheckedChangedEventArgs e)
    { 
        if(sender is CheckBox checkBox){
            if (checkBox.IsChecked)
            {
                if (checkBox == regCrust)
                {
                    
                }
                else if (checkBox == glutenfreeCrust)
                {
                   
                }
            }
            }
    
    }

        private void continueOn_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new SummaryPage(pushedCustomerData));
    }
}