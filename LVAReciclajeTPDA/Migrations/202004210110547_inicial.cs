namespace LVAReciclajeTPDA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class inicial : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.EmployeeDetails", "Employee_Id", "dbo.Employees");
            DropForeignKey("dbo.EmployeeDetails", "Product_Id", "dbo.Products");
            DropIndex("dbo.EmployeeDetails", new[] { "Employee_Id" });
            DropIndex("dbo.EmployeeDetails", new[] { "Product_Id" });
            AddColumn("dbo.Employees", "ImageUrl", c => c.String());
            DropColumn("dbo.Employees", "Name");
            DropColumn("dbo.PurchaseDetails", "BuyerName");
            DropColumn("dbo.Sales", "SellerName");
            DropColumn("dbo.SaleDetails", "SellerName");
            DropColumn("dbo.Purchases", "BuyerName");
            DropTable("dbo.EmployeeDetails");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.EmployeeDetails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        FullName = c.String(),
                        NumberPhone = c.Int(nullable: false),
                        Address = c.String(),
                        ZipCode = c.Int(nullable: false),
                        StreetNumber = c.Int(nullable: false),
                        City = c.String(),
                        Gender = c.String(),
                        MaritalStatus = c.String(),
                        PlaceOfBirth = c.String(),
                        HealthInsurance = c.String(),
                        Employee_Id = c.Int(),
                        Product_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Purchases", "BuyerName", c => c.String());
            AddColumn("dbo.SaleDetails", "SellerName", c => c.String());
            AddColumn("dbo.Sales", "SellerName", c => c.String());
            AddColumn("dbo.PurchaseDetails", "BuyerName", c => c.String());
            AddColumn("dbo.Employees", "Name", c => c.String());
            DropColumn("dbo.Employees", "ImageUrl");
            CreateIndex("dbo.EmployeeDetails", "Product_Id");
            CreateIndex("dbo.EmployeeDetails", "Employee_Id");
            AddForeignKey("dbo.EmployeeDetails", "Product_Id", "dbo.Products", "Id");
            AddForeignKey("dbo.EmployeeDetails", "Employee_Id", "dbo.Employees", "Id");
        }
    }
}
