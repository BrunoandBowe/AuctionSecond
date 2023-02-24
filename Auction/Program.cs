using System;
namespace Auction 
{
    public class Driver
    {

        public static void Main(string[] args)
        {
            Product brush = new Product(1, "Tooth brush", 25);
            brush.Quantity -= 100;
            Console.WriteLine(brush);
           

        }






    }
}
