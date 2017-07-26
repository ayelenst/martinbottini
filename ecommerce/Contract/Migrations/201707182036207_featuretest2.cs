namespace Manager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class featuretest2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Features", "ProductID", "dbo.Products");
            DropIndex("dbo.Features", new[] { "ProductID" });
            DropTable("dbo.Features");
            CreateTable(
              "dbo.Features",
              c => new
              {
                  Id = c.Int(nullable: false, identity: true),
                  Name = c.String(),
                  Description = c.String(),
                  ProductID = c.Int(nullable: false),
              })
              .PrimaryKey(t => t.Id)
              .ForeignKey("dbo.Products", t => t.ProductID, cascadeDelete: true)
              .Index(t => t.ProductID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Features", "ProductID", "dbo.Products");
            DropIndex("dbo.Features", new[] { "ProductID" });
            DropTable("dbo.Features");
        }
    }
}
