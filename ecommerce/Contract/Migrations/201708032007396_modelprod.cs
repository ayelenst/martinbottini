namespace Manager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class modelprod : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "Model", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "Model");
        }
    }
}
