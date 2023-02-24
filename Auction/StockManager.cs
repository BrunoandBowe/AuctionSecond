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
            AddTestingProducts();
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

       /// <summary>
       /// 
       /// </summary>
       /// <param name="id"></param>
       /// <returns></returns>
        public Product FindById(int id)
        {
           foreach(Product product in Products )
            {
                if(product.ID == id)
                {
                    return product;
                }
               

            }
            // if reached here no product matches so throw an eception
            throw new ArgumentException("No product by that id");
        }

        /// <summary>
        /// Creates and adds products to list for testing
        /// </summary>
        public void AddTestingProducts()
        {
            AddProduct(new Product(id, "Tooth Brush"));
            id++;
            AddProduct(new Product(id, " McAdams dog food"));
            id++;
            AddProduct(new Product(id, "Cat nip donut"));
            id++;
        }


        /// <summary>
        /// Read only property that returns this list 
        /// </summary>
        public List<Product> Products
        {
            get { return products;}
        }

    }
}
