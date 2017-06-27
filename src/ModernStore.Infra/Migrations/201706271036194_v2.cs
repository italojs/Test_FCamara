namespace TestFCamara.Infra.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Order", "Customer_Id", "dbo.Customer");
            DropForeignKey("dbo.OrderItem", "Product_Id", "dbo.Product");
            DropForeignKey("dbo.OrderItem", "Order_Id", "dbo.Order");
            DropIndex("dbo.Order", new[] { "Customer_Id" });
            DropIndex("dbo.OrderItem", new[] { "Product_Id" });
            DropIndex("dbo.OrderItem", new[] { "Order_Id" });
            DropColumn("dbo.Customer", "BirthDate");
            DropColumn("dbo.Customer", "Email_Address");
            DropColumn("dbo.Customer", "Document_Number");
            DropTable("dbo.Order");
            DropTable("dbo.OrderItem");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.OrderItem",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Quantity = c.Int(nullable: false),
                        Price = c.Decimal(nullable: false, storeType: "money"),
                        Product_Id = c.Guid(nullable: false),
                        Order_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Order",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        Number = c.String(nullable: false, maxLength: 8, fixedLength: true),
                        Status = c.Int(nullable: false),
                        DeliveryFee = c.Decimal(nullable: false, storeType: "money"),
                        Discount = c.Decimal(nullable: false, storeType: "money"),
                        Customer_Id = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Customer", "Document_Number", c => c.String(nullable: false, maxLength: 11, fixedLength: true));
            AddColumn("dbo.Customer", "Email_Address", c => c.String(nullable: false, maxLength: 160));
            AddColumn("dbo.Customer", "BirthDate", c => c.DateTime());
            CreateIndex("dbo.OrderItem", "Order_Id");
            CreateIndex("dbo.OrderItem", "Product_Id");
            CreateIndex("dbo.Order", "Customer_Id");
            AddForeignKey("dbo.OrderItem", "Order_Id", "dbo.Order", "Id");
            AddForeignKey("dbo.OrderItem", "Product_Id", "dbo.Product", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Order", "Customer_Id", "dbo.Customer", "Id", cascadeDelete: true);
        }
    }
}
