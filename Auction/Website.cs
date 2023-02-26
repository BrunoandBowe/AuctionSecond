using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auction
{
    /// <summary>
    /// The class that connects stock manager and orders 
    /// </summary>
    public class Website
    {
        private StockManager stock = new StockManager();

        public Website()
        {
            
        }

       /// <summary>
       /// Allow a customer to create an order
       /// Will utilise a stock manager to find the products 
       /// </summary>
       /// <param name="customer"> The customer making an order </param>
       /// <returns> The order the customer created </returns>
      //  public Order CreateOrder(Customer customer,Product product,int amount)
      //  {
       //     Product orderProduct = Stock.GetOrderProduct(product,amount);

       // }




        /// <summary>
        /// Find and return a product by a name
        /// </summary>
        /// <param name="productName"></param>
        /// <returns> A product found by name </returns>
        public Product SearchByName(string productName)
        {
            return Stock.FindByName(productName);
        }

        /// <summary>
        /// Lets a customer use the stock manager to find a product by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Product SearchById(int id)
        {
            return Stock.FindById(id);
        }


        public StockManager Stock
        {
            get { return stock; }
        }


    }
}
