using System;
using Newtonsoft.Json;
namespace XuanThuLab
{

    class Program{
        class Product{
            public string Name {set; get;}
            public DateTime Expiry {set; get;}
            public string[] Sizes {set; get;}
        }
        static void Main(string[] args){
            Product product = new Product();
            product.Name = "Apple";
            product.Expiry = new DateTime(2008, 12, 28);
            product.Sizes = new string[] { "Small" };

            string json = JsonConvert.SerializeObject(product);
            // {
            //   "Name": "Apple",
            //   "Expiry": "2008-12-28T00:00:00",
            //   "Sizes": [
            //     "Small"
            //   ]
            // }
            Console.WriteLine(json);

        }
    }
}