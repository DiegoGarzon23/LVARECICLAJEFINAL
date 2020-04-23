using System;
using System.Collections.Generic;


namespace LVAReciclajeTPDA.Data
{
    public class SaleDetail: IEntity
    {
        public int Id { get; set; }
        public string FullNameSeller { get; set; }
        public int SellerPhone { get; set; }
        public char SellerEmail { get; set; }
        public string BuyerName { get; set; }
        public string FullNameBuyer { get; set; }
        public int BuyerPhone { get; set; }
        public char BuyerEmail { get; set; }

        public Product Product { get; set; }
        public Sale Sale { get; set;}




    }
}
