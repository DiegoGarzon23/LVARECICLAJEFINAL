using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LVAReciclajeTPDA.Data
{
    public class Employee: IEntity
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(20)]
        public string FullName { get; set; }
        [Required]
        [StringLength(20)]
        public int NumberPhone { get; set; }
        [Required]
        [StringLength(20)]
        public string ContactEmail { get; set; }
        [Required]
        [StringLength(20)]
        public string Address { get; set; }
        [Required]
        [StringLength(20)]
        public int ZipCode { get; set; }
        public int StreetNumber { get; set; }
        public string City { get; set; }
        [Required]
        [StringLength(20)]
        public string Gender { get; set; }
        [Required]
        [StringLength(20)]
        public string MaritalStatus { get; set; }
        [Required]
        [StringLength(20)]
        public string PlaceOfBirth { get; set; }
        [Required]
        [StringLength(20)]
        public string HealthInsurance { get; set; }
        [Required]
        [StringLength(20)]
        public string ImageUrl { get; set; }


        public ICollection<Sale> Sales { get; set; }
      
    }
}
