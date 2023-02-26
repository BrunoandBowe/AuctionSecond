using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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
       /// <param name="product"> The product to get a certain amount of</param>
       /// <param name="amount"> The amount of product wanted </param>
       /// <returns></returns>
        public Product GetOrderProduct(Product product, int amount)
        {
            // Create a deep copy of the object that a customer wants ordering
            // need to do this as want to keep the product on the list 
            Product orderProduct = product.DeepCopy();
            // set order product quantity to the amount to purchase
            orderProduct.Quantity = amount;
            // now take away that amount from the original product 
            product.DecreaseQuantity(amount);
            return orderProduct;
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
        /// 
        /// </summary>
        /// <param name="productName"> The product name to search for </param>
        /// <returns></returns>
        public Product FindByName(string productName)
        {
            foreach (Product product in Products)
            {
                if(String.Equals(product.Name,productName, StringComparison.OrdinalIgnoreCase))
                {
                    return product;
                }
            }
            // out of loop so throw exception as product does not exists 
            throw new ArgumentException("No product by that name");
        }

        /// <summary>
        /// Creates and adds products to list for testing
        /// </summary>
        public void AddTestingProducts()
        {
            Product ToothBrush = new Product(id, "Tooth Brush");
            ToothBrush.IncreaseQuantity(50);
            Products.Add(ToothBrush);
            id++;
            Product DogFood = new Product(id, " McAdams dog food");
            DogFood.IncreaseQuantity(50);
            Products.Add(DogFood);
            id++;
            Product catnip = new Product(id, "Cat nip donut");
            catnip.IncreaseQuantity(50);
            Products.Add(catnip);
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
