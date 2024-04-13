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
        private PizzaSauce pizzaSauce;
        private PizzaCheese pizzaCheese;

        public Pizza()
        {
        }

        public Pizza(List<PizzaToppings> pizzaToppings, PizzaBase pizzaBase, PizzaSauce pizzaSauce, PizzaCheese pizzaCheese, string productName, int productID, int productQuantity, double productPrice) :
            base(productName, productID, productQuantity, productPrice)
        {
            this.pizzaToppings = pizzaToppings;
            this.pizzaBase = pizzaBase;
            this.pizzaSauce = pizzaSauce;
            this.pizzaCheese = pizzaCheese;
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

        public PizzaSauce PizzaSauce
        {
            get => pizzaSauce;
            set => pizzaSauce = value;
        }

        public PizzaCheese PizzaCheese
        {
            get => pizzaCheese;
            set => pizzaCheese = value;
        }

        public override string ToString()
        {
            string concatenatedToppings = "";
            pizzaToppings.ForEach(topping => concatenatedToppings += topping.ToString() + ", ");
            return $"Pizza info: Pizza base: {pizzaBase}, pizza sauce: {PizzaSauce}, pizza cheese: {pizzaCheese}, pizza toppings: {concatenatedToppings}";
        }

    }
}
