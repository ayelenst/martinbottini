namespace Manager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Features");
            CreateTable(
                "dbo.Images",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Url = c.String(),
                        IsMain = c.Boolean(nullable: false),
                        ProductId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Products", "Image_Id", c => c.Int());
            AlterColumn("dbo.Features", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Features", "Id");
            CreateIndex("dbo.Products", "Image_Id");
            AddForeignKey("dbo.Products", "Image_Id", "dbo.Images", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "Image_Id", "dbo.Images");
            DropIndex("dbo.Products", new[] { "Image_Id" });
            DropPrimaryKey("dbo.Features");
            AlterColumn("dbo.Features", "Id", c => c.String(nullable: false, maxLength: 128));
            DropColumn("dbo.Products", "Image_Id");
            DropTable("dbo.Images");
            AddPrimaryKey("dbo.Features", "Id");
        }
    }
}
