namespace Manager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Stock : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "Stock", c => c.Int());
            AddColumn("dbo.Products", "StatusStock", c => c.Int());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "StatusStock");
            DropColumn("dbo.Products", "Stock");
        }
    }
}
