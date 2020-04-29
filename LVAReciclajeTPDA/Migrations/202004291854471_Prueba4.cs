namespace LVAReciclajeTPDA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Prueba4 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PurchaseDetails", "Name", c => c.String());
            AddColumn("dbo.SaleDetails", "Name", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.SaleDetails", "Name");
            DropColumn("dbo.PurchaseDetails", "Name");
        }
    }
}
