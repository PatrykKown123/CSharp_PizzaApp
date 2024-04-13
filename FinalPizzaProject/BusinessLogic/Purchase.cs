using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalPizzaProject.BusinessLogic
{
    public class Purchase
    {
        private int transaction;
        private string productName;
        private double totalCost;
        private string purchaseLocation;

        public int Transaction
        {
            get => transaction;
            set => transaction = value;
        }
        public string ProductName
        {
            get => productName;
            set => productName = value;
        }
        public double TotalCost
        {
            get => totalCost;
            set => totalCost = value;
        }
        public string PurchaseLocation
        {
            get => purchaseLocation;
            set => purchaseLocation = value;
        }

        public Purchase() { }

        public Purchase(int transaction, string productName, double totalCost, string purchaseLocation)
        {
            this.transaction = transaction;
            this.productName = productName;
            this.totalCost = totalCost;
            this.purchaseLocation = purchaseLocation;
        }

        public override string ToString()
        {
            return $"Transaction: {transaction}, Product Name: {productName}, Total Cost: {totalCost}, Purchase Location: {purchaseLocation}";
        }

    }
}

