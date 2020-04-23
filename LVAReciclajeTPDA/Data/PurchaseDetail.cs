using System;
using System.Collections.Generic;


namespace LVAReciclajeTPDA.Data
{
    public class PurchaseDetail: IEntity
    {
        public int Id { get; set; }
        public string FullNameBuyer { get; set; }
        public int NumberPhone { get; set; }
        public string ContactEmail { get; set; }
        public string PurchaseProduct { get; set; }
        public string Billing { get; set; }
        public string Company { get; set; }
        public string Address { get; set; }
        public int CompanyPhone { get; set; }
        public string City { get; set; }
        public double Quantity { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
       
        public Sale Sale { get; set; }
        public Product Product { get; set; }
        
    }
}
