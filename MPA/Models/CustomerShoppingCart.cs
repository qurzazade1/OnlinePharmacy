using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OnlinePharmacy.Models
{
    public class CustomerShoppingCart
    {
        public CustomerShoppingCart()
        {
            Count = 1;
        }


        public int Id { get; set; }

        public string ApplicationUserId { get; set; }

        [NotMapped]
        [ForeignKey("ApplicationUserId")]
        public virtual ApplicationUser ApplicationUser { get; set; }

        public int MedicineId { get; set; }

        [NotMapped]
        [ForeignKey("MedicineId")]
        public virtual Medicine Medicine { get; set; }
        
        [Range(1,int.MaxValue, ErrorMessage ="Please enter a value greater than or equal to {1}")]
        public int Count { get; set; }
    }
}
