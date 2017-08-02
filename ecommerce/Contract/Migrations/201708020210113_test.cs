namespace Manager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.OrderStatus", "Name", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.OrderStatus", "Name", c => c.Int(nullable: false));
        }
    }
}
