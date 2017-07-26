namespace Manager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class imageproduct : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ImageProducts", "Image_Id", "dbo.Images");
            DropForeignKey("dbo.ImageProducts", "Product_Id", "dbo.Products");
            DropIndex("dbo.ImageProducts", new[] { "Image_Id" });
            DropIndex("dbo.ImageProducts", new[] { "Product_Id" });
            CreateIndex("dbo.Images", "ProductId");
            AddForeignKey("dbo.Images", "ProductId", "dbo.Products", "Id", cascadeDelete: true);
            DropTable("dbo.ImageProducts");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.ImageProducts",
                c => new
                    {
                        Image_Id = c.Int(nullable: false),
                        Product_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Image_Id, t.Product_Id });
            
            DropForeignKey("dbo.Images", "ProductId", "dbo.Products");
            DropIndex("dbo.Images", new[] { "ProductId" });
            CreateIndex("dbo.ImageProducts", "Product_Id");
            CreateIndex("dbo.ImageProducts", "Image_Id");
            AddForeignKey("dbo.ImageProducts", "Product_Id", "dbo.Products", "Id", cascadeDelete: true);
            AddForeignKey("dbo.ImageProducts", "Image_Id", "dbo.Images", "Id", cascadeDelete: true);
        }
    }
}
