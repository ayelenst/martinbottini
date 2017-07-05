namespace Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBlogUrl : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NameCustomer = c.String(),
                        OrderStateId = c.Int(nullable: false),
                        Mail = c.String(),
                        Phone = c.String(),
                        Payment = c.String(),
                        OrderStatus_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.OrderStatus", t => t.OrderStatus_Id)
                .Index(t => t.OrderStatus_Id);
            
            CreateTable(
                "dbo.OrderProducts",
                c => new
                    {
                        OrderProductId = c.Int(nullable: false, identity: true),
                        NameProduct = c.String(),
                        Quantity = c.Int(nullable: false),
                        Price = c.Double(nullable: false),
                        OrderId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.OrderProductId)
                .ForeignKey("dbo.Orders", t => t.OrderId, cascadeDelete: true)
                .Index(t => t.OrderId);
            
            CreateTable(
                "dbo.OrderStatus",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Categories", "Description", c => c.String());
            AddColumn("dbo.Categories", "Level", c => c.Int(nullable: false));
            AddColumn("dbo.Categories", "ParentId", c => c.Int(nullable: false));
            AddColumn("dbo.Categories", "Enabled", c => c.Boolean(nullable: false));
            AddColumn("dbo.Products", "Description", c => c.String());
            AddColumn("dbo.Products", "IsOffer", c => c.Boolean(nullable: false));
            AddColumn("dbo.Products", "Percent", c => c.Double(nullable: false));
            AddColumn("dbo.Products", "Enabled", c => c.Boolean(nullable: false));
            AddColumn("dbo.Products", "StartDay", c => c.DateTime(nullable: false));
            AddColumn("dbo.Products", "EndDay", c => c.DateTime(nullable: false));
            AddColumn("dbo.Products", "Price", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Orders", "OrderStatus_Id", "dbo.OrderStatus");
            DropForeignKey("dbo.OrderProducts", "OrderId", "dbo.Orders");
            DropIndex("dbo.OrderProducts", new[] { "OrderId" });
            DropIndex("dbo.Orders", new[] { "OrderStatus_Id" });
            DropColumn("dbo.Products", "Price");
            DropColumn("dbo.Products", "EndDay");
            DropColumn("dbo.Products", "StartDay");
            DropColumn("dbo.Products", "Enabled");
            DropColumn("dbo.Products", "Percent");
            DropColumn("dbo.Products", "IsOffer");
            DropColumn("dbo.Products", "Description");
            DropColumn("dbo.Categories", "Enabled");
            DropColumn("dbo.Categories", "ParentId");
            DropColumn("dbo.Categories", "Level");
            DropColumn("dbo.Categories", "Description");
            DropTable("dbo.Users");
            DropTable("dbo.OrderStatus");
            DropTable("dbo.OrderProducts");
            DropTable("dbo.Orders");
        }
    }
}
