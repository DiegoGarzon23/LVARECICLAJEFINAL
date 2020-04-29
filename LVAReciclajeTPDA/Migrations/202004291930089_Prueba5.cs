namespace LVAReciclajeTPDA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Prueba5 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PurchaseDetails", "TerminationDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.PurchaseDetails", "TerminationDate");
        }
    }
}
