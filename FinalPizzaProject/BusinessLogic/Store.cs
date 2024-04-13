using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalPizzaProject.BusinessLogic
{
    public class Store
    {
        private string storeName;
        private int storeID;
        private List<Product> products;

        public Store() { }

        public Store(string storeName, int storeID, List<Product> products)
        {
            this.storeID = storeID;
            this.storeName = storeName;
            this.products = products;
        }

        public string StoreName
        {
            get => storeName;
            set => storeName = value;
        }

        public int StoreID
        {
            get => storeID;
            set => storeID = value;
        }

        public List<Product> Products
        {
            get => products;
            set => products = value;
        }

        public override string ToString()
        {
            return $"Store name: {storeName}, store ID: {storeID}, # of product options: {products.Count}";
        }
    }
}
