using System;
using System.Collections.Generic;


namespace LVAReciclajeTPDA.Data
{
    public class SaleDetail: IEntity
    {
        public int Id { get; set; }
        public DateTime AssingmentDate { get; set; }
        public DateTime TerminationDate { get; set; }
        public string Description { get; set; }

        public Product Product { get; set; }
        public Sale Sale { get; set;}




    }
}
