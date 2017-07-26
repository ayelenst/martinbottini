namespace Manager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class brand : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "Brant", c => c.String());
            AddColumn("dbo.Products", "Warranty", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "Warranty");
            DropColumn("dbo.Products", "Brant");
        }
    }
}
