namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBirthdateToCustomer1 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Customers", "Birthday");
        }
        
        public override void Down()
        {
        }
    }
}
