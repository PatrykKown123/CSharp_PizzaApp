namespace FinalPizzaProject.ProjectUI;

public partial class PizzaBuilder : ContentPage
{
    List<CheckBox> checkboxes = new List<CheckBox>();
    Dictionary<CheckBox, Image> toppingsDictionary = new Dictionary<CheckBox, Image>(); // Dictionary to map checkboxes to their corresponding topping images

    Image pepperoniImage = new Image()
    {
        Source = "pepperoni.png",
        WidthRequest = 300
    };
    public PizzaBuilder()
	{
		InitializeComponent();
        toppingsDictionary.Add(pepperoni, pepperoniImage);
    }

    void CheckBox_CheckedChanged(object sender, CheckedChangedEventArgs e)
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



}