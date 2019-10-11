﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlinePharmacy.Models.ViewModels
{
    public class CustomerOrderListViewModel
    {
        public IList<CustomerOrderDetailsViewModel> Orders { get; set; }
       public PagingInfo PagingInfo { get; set; }
    }
}
