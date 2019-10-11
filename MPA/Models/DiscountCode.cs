using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlinePharmacy.Models
{
    public class DiscountCode
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string DiscountCodeType { get; set; }

        public enum EDiscountCodeType { Percent = 0, Dollar = 1 }

        [Required]
        public double DiscountAmount { get; set; }

        [Required]
        public double MinimumAmount { get; set; }

        public byte[] Picture { get; set; }

        public bool IsActive { get; set; }
    }
}
