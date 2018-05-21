namespace Vapor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedGameModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Games", "ReleaseDate", c => c.String());
            AddColumn("dbo.Games", "Price", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Games", "Price");
            DropColumn("dbo.Games", "ReleaseDate");
        }
    }
}
