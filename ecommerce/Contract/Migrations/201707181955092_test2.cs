namespace Manager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Products", "Image_Id", "dbo.Images");
            DropIndex("dbo.Products", new[] { "Image_Id" });
            CreateTable(
                "dbo.Banners",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ImageUrl = c.String(),
                        Title = c.String(),
                        Description = c.String(),
                        Url = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ImageProducts",
                c => new
                    {
                        Image_Id = c.Int(nullable: false),
                        Product_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Image_Id, t.Product_Id })
                .ForeignKey("dbo.Images", t => t.Image_Id, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.Product_Id, cascadeDelete: true)
                .Index(t => t.Image_Id)
                .Index(t => t.Product_Id);
            
            DropColumn("dbo.Products", "Image_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "Image_Id", c => c.Int());
            DropForeignKey("dbo.ImageProducts", "Product_Id", "dbo.Products");
            DropForeignKey("dbo.ImageProducts", "Image_Id", "dbo.Images");
            DropIndex("dbo.ImageProducts", new[] { "Product_Id" });
            DropIndex("dbo.ImageProducts", new[] { "Image_Id" });
            DropTable("dbo.ImageProducts");
            DropTable("dbo.Banners");
            CreateIndex("dbo.Products", "Image_Id");
            AddForeignKey("dbo.Products", "Image_Id", "dbo.Images", "Id");
        }
    }
}
