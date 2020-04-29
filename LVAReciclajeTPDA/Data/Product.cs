using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LVAReciclajeTPDA.Data
{
    public class Product: IEntity
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(20)]
        public string Name { get; set; }
        [Required]
        [StringLength(20)]
        public double Quantity { get; set; }
        public double Price { get; set; }
        [Required]
        [StringLength(20)]
        public string Description { get; set; }
        public int Code { get; set; }
        [Required]
        [StringLength(20)]
        public string TypeProduct { get; set; }

        public ICollection<PurchaseDetail> PurchaseDetails { get; set; }
        public ICollection<SaleDetail> SaleDetails { get; set; }


    }
}
