using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auction
{
    /// <summary>
    /// A customer that can make an order of a product 
    /// </summary>
    public class Customer
    {
        public string Address { get; private set; }
        public string Name { get; private set; }

        public Customer(string address,string name)
        {
            Address = address;
            Name = name;
        }





    }
}
