using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShop.ProductData
{
    public class Electronics : Product
    {
        public int WarrantyYears;

        public override string ProductInformation()
        {
            return $"Prroduct {Name} by {Brand} costs {Price}. Warranty is {WarrantyYears}";
        }
    }
}
