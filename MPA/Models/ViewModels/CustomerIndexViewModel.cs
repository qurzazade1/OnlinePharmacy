using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlinePharmacy.Models.ViewModels
{
    public class CustomerIndexViewModel
    {
       
        public IEnumerable<DiscountCode> DiscountCode { get; set; }
        public IEnumerable<Medicine> Medicine { get; set; }
        public IEnumerable<MedicineType> MedicineType { get; set; }
    }
}
