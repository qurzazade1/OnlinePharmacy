using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace  OnlinePharmacy.Models.ViewModels
{
    public class MedicineViewModel
    {
        public Medicine Medicine { get; set; }
        public IEnumerable<MedicineType> MedicineType { get; set; }
        public IEnumerable<MedicineSubtype> MedicineSubtype { get; set; }
    }
}
