using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using FinalPizzaProject.BusinessLogic;
using FinalPizzaProject.ProjectUI;

namespace FinalPizzaProject.DataLayer
{
    public class DataManager
    {
        string filename = "testingFile.json";
        //public static List<Customer> customerDataBase = DataManager.ReadFromFile();

        public async Task WriteToFile(Customer customerInfo, List<Customer> customers)
        {

            customers.Add(customerInfo);
            string targetFile = System.IO.Path.Combine(FileSystem.Current.AppDataDirectory, filename);
            Debug.WriteLine(targetFile);

            using FileStream inputStream = System.IO.File.OpenWrite(targetFile);
            await JsonSerializer.SerializeAsync(inputStream, customers);
        }

        public async Task UpdateWriteFile(List<Customer> customers) {
            string targetFile = System.IO.Path.Combine(FileSystem.Current.AppDataDirectory, filename);
            Debug.WriteLine(targetFile);

            using FileStream inputStream = System.IO.File.OpenWrite(targetFile);
            await JsonSerializer.SerializeAsync(inputStream, customers);
        }

        public List<Customer> PopulateList() {
            string targetFile = Path.Combine(FileSystem.Current.AppDataDirectory, filename);
            Debug.WriteLine(targetFile);
            FileStream inputStream = File.OpenRead(targetFile);

            //BASICALLLYY if targetFile is null, it will return an instance of List<Customer> instead because returning null is dangerous!
            List<Customer> tempList = JsonSerializer.Deserialize<List<Customer>>(inputStream) ?? new List<Customer>();
            return tempList;

        }
/*
        public async void ReadFromFile()
        {
            string targetFile = System.IO.Path.Combine(FileSystem.Current.AppDataDirectory, filename);
            Debug.WriteLine(targetFile);
            using FileStream inputStream = System.IO.File.OpenRead(targetFile);
            CreateAmount.customerDatabase = await JsonSerializer.DeserializeAsync<List<Customer>>(inputStream) ?? new List<Customer>();
        }
*/
    }
}
