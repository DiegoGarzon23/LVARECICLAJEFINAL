using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LVAReciclajeTPDA.Data
{
    public class Purchase: IEntity
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(20)]
        public string FullNameBuyer { get; set; }
        public int NumberPhone { get; set; }
        [Required]
        [StringLength(20)]
        public string ContactEmail { get; set; }
        [Required]
        [StringLength(20)]
        public string PurchaseProduct { get; set; }
        [Required]
        [StringLength(20)]
        public string Billing { get; set; }
        [Required]
        [StringLength(20)]
        public string Company { get; set; }
        [Required]
        [StringLength(20)]
        public string Address { get; set; }
        public int CompanyPhone { get; set; }
        [Required]
        [StringLength(20)]
        public string City { get; set; }
        public double Quantity { get; set; }
        public double Price { get; set; }
        [Required]
        [StringLength(20)]
        public string Description { get; set; }
        

        public ICollection<PurchaseDetail> PurchaseDetails { get; set; }
        public ICollection<Product> Products { get; set; }

    }
}
