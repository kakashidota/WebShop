using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShop.ProductData
{

    public class Clothing : Product
    {
        public string Size;


        public override string ProductInformation()
        {
            return $"{Name} is of brand {Brand}, size: {Size}. Price is {Price}";
        }
    }
}
