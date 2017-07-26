namespace Manager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Stock2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "TypeStock", c => c.Int());
            DropColumn("dbo.Products", "StatusStock");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "StatusStock", c => c.Int());
            DropColumn("dbo.Products", "TypeStock");
        }
    }
}
