namespace Manager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class feature : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Features");
            AlterColumn("dbo.Features", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Features", "Id");
        }
        
        public override void Down()
        {
        }
    }
}
