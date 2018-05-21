namespace Vapor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InsertCustomerBirthData : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "BirthDate", c => c.String());
            DropColumn("dbo.Customers", "Date");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "Date", c => c.String());
            DropColumn("dbo.Customers", "BirthDate");
        }
    }
}
