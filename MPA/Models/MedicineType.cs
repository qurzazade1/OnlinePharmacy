using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlinePharmacy.Models
{
    public class MedicineType
    {
        [Key]
        public int Id { get; set; }

        [Display(Name= "Name Of The MediicneType")]
        [Required]
        public string Name { get; set; }
    }
}
