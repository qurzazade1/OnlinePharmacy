using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
namespace OnlinePharmacy.Models
{
    public class MedicineSubtype
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "MedicineSubtype Name")]
        [Required]
        public string Name { get; set; }

        [Required]
        [Display(Name = "MedicineType")]
        public int MedicineTypeId { get; set; }

          [ForeignKey("MedicineTypeId")]
        public virtual MedicineType MedicineType { get; set; }

    }
}
