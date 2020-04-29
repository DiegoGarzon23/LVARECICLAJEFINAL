using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LVAReciclajeTPDA.Data
{
    public class PurchaseDetail: IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime AssingmentDate { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime TerminationDate { get; set; }
        public string Description { get; set; }
       
        public Sale Sale { get; set; }
        public Product Product { get; set; }
        
    }
}
