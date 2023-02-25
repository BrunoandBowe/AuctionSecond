using System;
namespace Auction 
{
    public class Driver
    {

        public static void Main(string[] args)
        {
            StockManager stockManager = new StockManager();
            Product toothBrush = new Product(1, "ToothBrush");
            toothBrush.IncreaseQuantity(20);
            toothBrush.IncreaseQuantity(-30);
            Console.WriteLine(toothBrush);
           

        }






    }
}
