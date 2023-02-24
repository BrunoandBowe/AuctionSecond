using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auction
{
    /// <summary>
    /// A model of a product sold by a company
    /// </summary>
    public class Product
    {
        // the backing field keeps track of the products id
        private int id;
        // the name of this product
        private string name;
        // the quantity available 
        private int quantity;


        public Product(int id, string name, int quantity)
        {
            ID = id;
            Name = name;
            Quantity = quantity;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"> The id of this product</param>
        /// <param name="name"> The name of this product </param>
        public Product(int id, string name)
        {
            ID = id;
            Name = name;
            Quantity = 0;
        }

        public override string ToString()
        {
            return "Product " + Name + " with ID of: " + ID + 
            "\n stock level is currently at: " + Quantity;
        }

        /// <summary>
        /// Increase the stock of this product by a certain amount
        /// </summary>
        /// <param name="newStockAmount"></param>
        public void IncreaseQuantity(int newStockAmount)
        {
            Quantity += newStockAmount;
        }

        /// <summary>
        /// Decrease the level of stock of this product by a certain amount
        /// </summary>
        /// <param name="amountToTakeOff"> The amount to take of the stcok </param>
        public void DecreaseQuantity(int amountToTakeOff)
        {
            int quantityCheck = Quantity;
            {   //check amount would not take stock level to below 0
                if(quantityCheck - amountToTakeOff > 0)
                {
                    Quantity -= amountToTakeOff;
                }
                else
                {
                    throw new ArgumentException("Insufficent stock to purchase this amount");
                }
            }
        }

      






        public int Quantity
        {
            get { return quantity; }
            set
            {
                if(value > 0)
                {
                    quantity = value;
                }
            }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }


        public int ID
        {
            get
            {
                return id;
            }
            set 
            {
                if(value > 0)
                {
                    id = value;
                }
            }
        }      

    }
}
