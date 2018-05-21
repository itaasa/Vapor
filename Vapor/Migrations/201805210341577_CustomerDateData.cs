namespace Vapor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CustomerDateData : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customer SET BirthDate = '06/09/96' WHERE Id=1");
        }
        
        public override void Down()
        {
        }
    }
}
