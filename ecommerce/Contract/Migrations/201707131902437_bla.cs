namespace Manager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class bla : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Features",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                        Description = c.String(),
                        ProductID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Products", t => t.ProductID, cascadeDelete: true)
                .Index(t => t.ProductID);
            
            AddColumn("dbo.Categories", "Model", c => c.String());
            AddColumn("dbo.Categories", "Warranty", c => c.String());
            AddColumn("dbo.Categories", "Brand", c => c.String());
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Features", "ProductID", "dbo.Products");
            DropIndex("dbo.Features", new[] { "ProductID" });
            DropColumn("dbo.Categories", "Brand");
            DropColumn("dbo.Categories", "Warranty");
            DropColumn("dbo.Categories", "Model");
            DropTable("dbo.Features");
        }
    }
}
