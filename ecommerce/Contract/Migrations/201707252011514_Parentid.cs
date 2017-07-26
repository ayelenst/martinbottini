namespace Manager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Parentid : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Categories", "ParentId", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Categories", "ParentId", c => c.Int(nullable: false));
        }
    }
}
