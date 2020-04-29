namespace LVAReciclajeTPDA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class prueba33 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PurchaseDetails", "AssingmentDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.SaleDetails", "AssingmentDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.SaleDetails", "TerminationDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.SaleDetails", "Description", c => c.String());
            DropColumn("dbo.PurchaseDetails", "FullNameBuyer");
            DropColumn("dbo.PurchaseDetails", "NumberPhone");
            DropColumn("dbo.PurchaseDetails", "ContactEmail");
            DropColumn("dbo.PurchaseDetails", "PurchaseProduct");
            DropColumn("dbo.PurchaseDetails", "Billing");
            DropColumn("dbo.PurchaseDetails", "Company");
            DropColumn("dbo.PurchaseDetails", "Address");
            DropColumn("dbo.PurchaseDetails", "CompanyPhone");
            DropColumn("dbo.PurchaseDetails", "City");
            DropColumn("dbo.PurchaseDetails", "Quantity");
            DropColumn("dbo.PurchaseDetails", "Price");
            DropColumn("dbo.SaleDetails", "FullNameSeller");
            DropColumn("dbo.SaleDetails", "SellerPhone");
            DropColumn("dbo.SaleDetails", "BuyerName");
            DropColumn("dbo.SaleDetails", "FullNameBuyer");
            DropColumn("dbo.SaleDetails", "BuyerPhone");
        }
        
        public override void Down()
        {
            AddColumn("dbo.SaleDetails", "BuyerPhone", c => c.Int(nullable: false));
            AddColumn("dbo.SaleDetails", "FullNameBuyer", c => c.String());
            AddColumn("dbo.SaleDetails", "BuyerName", c => c.String());
            AddColumn("dbo.SaleDetails", "SellerPhone", c => c.Int(nullable: false));
            AddColumn("dbo.SaleDetails", "FullNameSeller", c => c.String());
            AddColumn("dbo.PurchaseDetails", "Price", c => c.Double(nullable: false));
            AddColumn("dbo.PurchaseDetails", "Quantity", c => c.Double(nullable: false));
            AddColumn("dbo.PurchaseDetails", "City", c => c.String());
            AddColumn("dbo.PurchaseDetails", "CompanyPhone", c => c.Int(nullable: false));
            AddColumn("dbo.PurchaseDetails", "Address", c => c.String());
            AddColumn("dbo.PurchaseDetails", "Company", c => c.String());
            AddColumn("dbo.PurchaseDetails", "Billing", c => c.String());
            AddColumn("dbo.PurchaseDetails", "PurchaseProduct", c => c.String());
            AddColumn("dbo.PurchaseDetails", "ContactEmail", c => c.String());
            AddColumn("dbo.PurchaseDetails", "NumberPhone", c => c.Int(nullable: false));
            AddColumn("dbo.PurchaseDetails", "FullNameBuyer", c => c.String());
            DropColumn("dbo.SaleDetails", "Description");
            DropColumn("dbo.SaleDetails", "TerminationDate");
            DropColumn("dbo.SaleDetails", "AssingmentDate");
            DropColumn("dbo.PurchaseDetails", "AssingmentDate");
        }
    }
}
