namespace LVAReciclajeTPDA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class prueba7 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Sales", "ZipCode", c => c.Int(nullable: false));
            AlterColumn("dbo.PurchaseDetails", "Name", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.PurchaseDetails", "Description", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.SaleDetails", "Name", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.SaleDetails", "Description", c => c.String(nullable: false, maxLength: 20));
            DropColumn("dbo.Sales", "BuyerName");
            DropColumn("dbo.Sales", "FullNameBuyer");
            DropColumn("dbo.Sales", "BuyerPhone");
            DropColumn("dbo.Sales", "BuyerEmail");
            DropColumn("dbo.Sales", "Company");
            DropColumn("dbo.Sales", "TotalCost");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Sales", "TotalCost", c => c.Double(nullable: false));
            AddColumn("dbo.Sales", "Company", c => c.String());
            AddColumn("dbo.Sales", "BuyerEmail", c => c.String());
            AddColumn("dbo.Sales", "BuyerPhone", c => c.Int(nullable: false));
            AddColumn("dbo.Sales", "FullNameBuyer", c => c.String());
            AddColumn("dbo.Sales", "BuyerName", c => c.String());
            AlterColumn("dbo.SaleDetails", "Description", c => c.String());
            AlterColumn("dbo.SaleDetails", "Name", c => c.String());
            AlterColumn("dbo.PurchaseDetails", "Description", c => c.String());
            AlterColumn("dbo.PurchaseDetails", "Name", c => c.String());
            DropColumn("dbo.Sales", "ZipCode");
        }
    }
}
