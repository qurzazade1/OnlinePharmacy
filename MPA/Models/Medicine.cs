using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OnlinePharmacy.Models
{    
    public class Medicine
    {
        public int Id { get; set; }

       // [Required]
        public string Name { get; set; }
        public string Description { get; set; }

        public string Country { get; set; }
        public enum ECountry { NA = 0, Azerbaijan = 1, Hungary = 2, Israiel = 3 }

        public string Image { get; set; }

        [Display(Name = "MedicineType")]
        public int MedicineTypeId { get; set; }

      [ForeignKey("MedicineTypeId")]
       public virtual MedicineType MedicineType { get; set; }

        [Display(Name = "MedicineSubtype")]
        public int MedicineSubtypeId { get; set; }

        [ForeignKey("MedicineSubtypeId")]
        public virtual MedicineSubtype MedicineSubtype { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = " Price should be greater than ${1}")]
       public double Price { get; set; }

        
    }
}
