using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LVAReciclajeTPDA.Data
{
    public class Sale: IEntity
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(20)]
        public string FullNameSeller { get; set; }
        public int SellerPhone { get; set; }
        [Required]
        [StringLength(20)]
        public string SellerEmail { get; set; }
        [Required]
        [StringLength(20)]
        public string Product { get; set; }
        [Required]
        [StringLength(20)]
        public string Billing { get; set; }
        [Required]
        [StringLength(20)]
        public string SendTo { get; set; }
        [Required]
        [StringLength(20)]
        public string Address { get; set; }
        [Required]
        [StringLength(20)]
        public int CompanyPhone { get; set; }
        [Required]
        [StringLength(20)]
        public string City { get; set; }
        public int ZipCode { get; set; }
        public double Quantity { get; set; }
        [Required]
        [StringLength(20)]
        public string Description { get; set; }
        public double SalePrice { get; set; }
        
        

        public ICollection<PurchaseDetail> PurchaseDetails { get; set; }
        public ICollection<Employee> Employees { get; set; }
    

    }
}
