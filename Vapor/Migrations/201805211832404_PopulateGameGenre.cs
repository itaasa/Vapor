namespace Vapor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGameGenre : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT GameGenres ON");
            Sql("INSERT INTO GameGenres (Id, Name) VALUES (1, 'Horror')");
            Sql("INSERT INTO GameGenres (Id, Name) VALUES (2, 'MOBA')");
            Sql("INSERT INTO GameGenres (Id, Name) VALUES (3, 'MMORPG')");
            Sql("INSERT INTO GameGenres (Id, Name) VALUES (4, 'Survival')");
            Sql("INSERT INTO GameGenres (Id, Name) VALUES (5, 'Battle Royale')");
            Sql("INSERT INTO GameGenres (Id, Name) VALUES (6, 'Arcade')");
            Sql("INSERT INTO GameGenres (Id, Name) VALUES (7, 'Trading Card')");
        }
        
        public override void Down()
        {
        }
    }
}
