using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalPizzaProject.BusinessLogic
{
    public class Customer
    {
        private string customerName;
        private string customerLocation;
        public List<Purchase> purchases = new List<Purchase>();
        private int customerID;
        private string customerPassword;
        private string customerEmail;
        private string customerPhone;

        public Customer() { }

        public Customer(string customerName, string customerLocation, List<Purchase> purchases, int customerID, string customerPassword, string customerEmail, string customerPhone)
        {
            this.customerName = customerName;
            this.customerLocation = customerLocation;
            this.purchases = purchases;
            this.customerID = customerID;
            this.customerPassword = customerPassword;
            this.customerEmail = customerEmail;
            this.customerPhone = customerPhone;
        }

        public string CustomerName
        {
            get => customerName;
            set => customerName = value;
        }
        public string CustomerLocation
        {
            get => customerLocation;
            set => customerLocation = value;
        }
        public List<Purchase> Purchases
        {
            get => purchases;
            set => purchases = value;
        }
        public int CustomerID
        {
            get => customerID;
            set => customerID = value;
        }
        public string CustomerPassword
        {
            get => customerPassword;
            set => customerPassword = value;
        }
        public string CustomerEmail
        {
            get => customerEmail;
            set => customerEmail = value;
        }
        public string CustomerPhoneNumber
        { 
            get => customerPhone;
            set => customerPhone = value;
        }

        public override string ToString()
        {
            return $"Customer ID: {customerID}, Name: {customerName}, Location: {customerLocation}, Email: {customerEmail}, Phone:{customerPhone}";
        }

    }
}
