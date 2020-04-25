namespace LVAReciclajeTPDA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class prueba2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "ContactEmail", c => c.String());
            AddColumn("dbo.Sales", "SellerEmail", c => c.String());
            AddColumn("dbo.Sales", "BuyerEmail", c => c.String());
            AlterColumn("dbo.Providers", "Address", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Providers", "Address", c => c.Int(nullable: false));
            DropColumn("dbo.Sales", "BuyerEmail");
            DropColumn("dbo.Sales", "SellerEmail");
            DropColumn("dbo.Employees", "ContactEmail");
        }
    }
}
