using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlinePharmacy.Models.ViewModels
{
    public class CustomerOrderDetailsCart
    {
        public List<CustomerShoppingCart> listCart { get; set; }
        public CustomerOrderHeader CustomerOrderHeader { get; set; }
    }
}
