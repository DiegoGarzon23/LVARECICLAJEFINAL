using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LVAReciclajeTPDA.Data
{
    public class Provider
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(20)]
        public string EnterpriseName { get; set; }
        [Required]
        [StringLength(20)]
        public string Brand { get; set; }
        [Required]
        [StringLength(20)]
        public string Address { get; set; }
        [Required]
        [StringLength(20)]
        public string City { get; set; }
        public int PostalCode { get; set; }
        public int PhoneNumber { get; set; }
        [Required]
        [StringLength(20)]
        public string Mail { get; set; }
        [Required]
        [StringLength(20)]
        public string Web { get; set; }

        public string ImageUrl { get; set; }

        public ICollection<Purchase> Purchases { get; set; }
        public ICollection<PurchaseDetail> PurchaseDetails { get; set; }

    }
}
