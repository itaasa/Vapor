namespace Vapor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class GenreData : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Games",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Genre_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.GameGenres", t => t.Genre_Id)
                .Index(t => t.Genre_Id);
            
            CreateTable(
                "dbo.GameGenres",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Games", "Genre_Id", "dbo.GameGenres");
            DropIndex("dbo.Games", new[] { "Genre_Id" });
            DropTable("dbo.GameGenres");
            DropTable("dbo.Games");
        }
    }
}
