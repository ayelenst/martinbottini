namespace Manager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class orderstatus : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Orders", "OrderStatus_Id", "dbo.OrderStatus");
            DropIndex("dbo.Orders", new[] { "OrderStatus_Id" });
            RenameColumn(table: "dbo.Orders", name: "OrderStatus_Id", newName: "OrderStatusId");
            AlterColumn("dbo.Orders", "OrderStatusId", c => c.Int(nullable: false));
            CreateIndex("dbo.Orders", "OrderStatusId");
            AddForeignKey("dbo.Orders", "OrderStatusId", "dbo.OrderStatus", "Id", cascadeDelete: true);
            DropColumn("dbo.Orders", "OrderStateId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Orders", "OrderStateId", c => c.Int(nullable: false));
            DropForeignKey("dbo.Orders", "OrderStatusId", "dbo.OrderStatus");
            DropIndex("dbo.Orders", new[] { "OrderStatusId" });
            AlterColumn("dbo.Orders", "OrderStatusId", c => c.Int());
            RenameColumn(table: "dbo.Orders", name: "OrderStatusId", newName: "OrderStatus_Id");
            CreateIndex("dbo.Orders", "OrderStatus_Id");
            AddForeignKey("dbo.Orders", "OrderStatus_Id", "dbo.OrderStatus", "Id");
        }
    }
}
