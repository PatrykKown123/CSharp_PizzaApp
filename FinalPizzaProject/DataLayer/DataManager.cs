using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using FinalPizzaProject.BusinessLogic;

namespace FinalPizzaProject.DataLayer
{
    public class DataManager
    {
        //public static string customerInfoFile = FileSystem.AppDataDirectory + "/CustomerInfos.json";

        string filename = "testingFile.json";
        public static List<Customer> customerDataBase = new List<Customer>();

        public async void WriteToFile(Customer customerInfo)
        {
            customerDataBase.Add(customerInfo); 
            string targetFile = System.IO.Path.Combine(FileSystem.Current.AppDataDirectory, filename);
            Debug.WriteLine(targetFile);
            using FileStream inputStream = System.IO.File.OpenWrite(targetFile);
            await JsonSerializer.SerializeAsync(inputStream, customerDataBase);
        }

        public async void ReadFromFile()
        {
            string targetFile = System.IO.Path.Combine(FileSystem.Current.AppDataDirectory, filename);
            Debug.WriteLine(targetFile);
            using FileStream inputStream = System.IO.File.OpenRead(targetFile);
            customerDataBase = await JsonSerializer.DeserializeAsync<List<Customer>>(inputStream);
        }
    }
}
