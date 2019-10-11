using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlinePharmacy.Models.ViewModels
{
    public class CustomerOrderDetailsViewModel
    {
        public CustomerOrderHeader CustomerOrderHeader { get; set; }
        public List<CustomerCustomerOrderDetails> CustomerOrderDetails { get; set; }
    }
}
