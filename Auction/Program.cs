using System;
namespace Auction 
{
    public class Driver
    {

        public static void Main(string[] args)
        {
            StockManager stockManager = new StockManager();
            Console.WriteLine(stockManager.FindById(2));
           

        }






    }
}
