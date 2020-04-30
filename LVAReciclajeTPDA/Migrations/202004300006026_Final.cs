namespace LVAReciclajeTPDA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Final : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.PurchaseDetails", "AssingmentDate", c => c.String());
            AlterColumn("dbo.SaleDetails", "AssingmentDate", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.SaleDetails", "AssingmentDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.PurchaseDetails", "AssingmentDate", c => c.DateTime(nullable: false));
        }
    }
}
