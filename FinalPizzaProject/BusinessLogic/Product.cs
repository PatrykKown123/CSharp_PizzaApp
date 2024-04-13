using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalPizzaProject.BusinessLogic
{
    public class Product
    {
        private string productName;
        private int productID;
        private int productQuantity;
        private double productPrice;

        public Product() { }

        public Product(string productName, int productID, int productQuantity, double productPrice)
        {
            this.productName = productName;
            this.productID = productID;
            this.productQuantity = productQuantity;
            this.productPrice = productPrice;
        }

        public string ProductName
        {
            get => productName;
            set => productName = value;
        }
        public int ProductID
        {
            get => productID;
            set => productID = value;
        }
        public int ProductQuantity
        {
            get => productQuantity;
            set => productQuantity = value;
        }
        public double ProductPrice
        {
            get => productPrice;
            set => productPrice = value;
        }

        public override string ToString()
        {
            return $"Product name: {productName}, product ID: {productID}, product quantity: {productQuantity}, product price: ${productPrice}";
        }
    }
}
