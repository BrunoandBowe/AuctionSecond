using System;
namespace Auction 
{
    public class Driver
    {

        public static void Main(string[] args)
        {
            StockManager stockManager = new StockManager();
            Console.WriteLine(stockManager.FindByName("Tooth Brush"));
           
           

        }

       // AddProduct(new Product(id, "Tooth Brush"));
          //  id++;
          //  AddProduct(new Product(id, " McAdams dog food"));
          //  id++;
          //  AddProduct(new Product(id, "Cat nip donut"));
          //  id++;




    }
}
