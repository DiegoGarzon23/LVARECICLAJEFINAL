using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LVAReciclajeTPDA.Data
{
    public class Client
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(20)]
        public string Name { get; set; }
        [Required]
        [StringLength(20)]
        public string Surnames { get; set; }
        [Required]
        [StringLength(20)]
        public string Rfc { get; set; }
        [Required]
        [StringLength(20)]
        public string Curp { get; set; }
        [Required]
        [StringLength(20)]
        public int Phone { get; set; }
        [Required]
        [StringLength(20)]
        public string Address { get; set; }
        [Required]
        [StringLength(20)]
        public int PostalCode { get; set; }
        [Required]
        [StringLength(20)]
        public string Contact { get; set; }
        [Required]
        [StringLength(20)]

        public string ImageUrl { get; set; }

        public ICollection<Employee> Employees { get; set; }
        public ICollection<Sale> Sales { get; set; }
    }
}
