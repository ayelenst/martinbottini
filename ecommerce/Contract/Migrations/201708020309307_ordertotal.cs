namespace Manager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ordertotal : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Orders", "Total", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Orders", "Total");
        }
    }
}
