using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auction
{
    public class Order
    {
        // the customers this delivers to
        private Customer customer;
        // the address to send to
        private string deliveryAdress;
        // is it delivered
        private bool delivered = false;
        // the product in this order 
        private List<Product> products;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="customer"> The customer who ordered this </param>
        /// <param name="deliveryAddress"> The address the customer chose to deliver to </param>
        /// <param name="products"> </param>>
        public Order(Customer customer,string deliveryAddress, List<Product> products)
        {
            this.customer = customer;
            this.deliveryAdress = deliveryAddress;
            this.products = products;
        }

        /// <summary>
        /// Print the order
        /// </summary>
        public void printOder()
        {
            System.Console.WriteLine("Delivering to " + customer.Name);
            foreach(Product product in Products)
            {
                System.Console.WriteLine(product);
            }
        }


        public List<Product> Products
        {
            get { return products; }
        }

    }
}
