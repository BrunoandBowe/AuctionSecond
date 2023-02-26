using System;
namespace Auction 
{
    public class Driver
    {

        public static void Main(string[] args)
        {
            StockManager stockManager = new StockManager();
            Product catnip = new Product(4, "catnip");
            catnip.IncreaseQuantity(25);
            Product orderCatnip =  stockManager.GetOrderProduct(catnip, 10);
            Console.WriteLine("The original should have 15 stock " + catnip);
            Console.WriteLine("The order product should have 10 stock " + orderCatnip);
           
           

        }






    }
}
