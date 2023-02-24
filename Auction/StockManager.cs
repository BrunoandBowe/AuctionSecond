using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auction
{   
    // A class to manage products 
    // A model to manange products
    // Can be used by a text UI or a graphical one 
    public class StockManager
    {
        // a list object of Product Objects
        private List<Product> products;
        // used to initalise Product objects with this param
        private int id;

        public StockManager()
        {
            products = new List<Product>();
            id = 1;
        }

        /// <summary>
        /// Used to add a product to the List of products
        /// Has the param needed for a Product object which is the id
        /// </summary>
        /// <param name="product"></param>
        public void AddProduct(Product product)
        {
            Products.Add(product);
        }    

       
        public Product FindById(int id)
        {

        }




        public List<Product> Products
        {
            get { return products;}
        }

    }
}
