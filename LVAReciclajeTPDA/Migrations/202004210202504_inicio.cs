namespace LVAReciclajeTPDA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class inicio : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Clients", "ImageUrl", c => c.String());
            AddColumn("dbo.Providers", "ImageUrl", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Providers", "ImageUrl");
            DropColumn("dbo.Clients", "ImageUrl");
        }
    }
}
