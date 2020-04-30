namespace LVAReciclajeTPDA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class prueba8 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.PurchaseDetails", "Name", c => c.String());
            AlterColumn("dbo.PurchaseDetails", "Description", c => c.String());
            AlterColumn("dbo.SaleDetails", "Name", c => c.String());
            AlterColumn("dbo.SaleDetails", "Description", c => c.String());
            DropColumn("dbo.PurchaseDetails", "TerminationDate");
            DropColumn("dbo.SaleDetails", "TerminationDate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.SaleDetails", "TerminationDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.PurchaseDetails", "TerminationDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.SaleDetails", "Description", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.SaleDetails", "Name", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.PurchaseDetails", "Description", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.PurchaseDetails", "Name", c => c.String(nullable: false, maxLength: 20));
        }
    }
}
