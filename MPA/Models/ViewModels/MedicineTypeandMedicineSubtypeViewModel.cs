using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlinePharmacy.Models.ViewModels
{
    public class MedicineTypeandMedicineSubtypeViewModel
    {
        public IEnumerable<MedicineType> MedicineTypeList { get; set; }
        public MedicineSubtype MedicineSubtype { get; set; }
        public List<string> MedicineSubtypeList { get; set; }
        public string StatusMessage { get; set; }
    }
}
