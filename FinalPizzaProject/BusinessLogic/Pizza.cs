using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalPizzaProject.BusinessLogic
{
    public class Pizza : Product
    {
        private List<PizzaToppings> pizzaToppings;
        private PizzaBase pizzaBase;


        public Pizza()
        {
        }

        public Pizza(List<PizzaToppings> pizzaToppings, PizzaBase pizzaBase, string productName, int productID, int productQuantity, double productPrice) :
            base(productName, productID, productQuantity, productPrice)
        {
            this.pizzaToppings = pizzaToppings;
            this.pizzaBase = pizzaBase;
        }

        public List<PizzaToppings> PizzaToppings
        {
            get => pizzaToppings;
            set => pizzaToppings = value;
        }

        public PizzaBase PizzaBase
        {
            get => pizzaBase;
            set => pizzaBase = value;
        }

        public override string ToString()
        {
            string concatenatedToppings = "";
            pizzaToppings.ForEach(topping => concatenatedToppings += topping.ToString() + ", ");
            return $"Pizza info: Pizza base: {pizzaBase}, pizza toppings: {concatenatedToppings}";
        }

    }
}
