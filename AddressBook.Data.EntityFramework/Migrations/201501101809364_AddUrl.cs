namespace AddressBook.Data.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUrl : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.People", "PhoneNumber", c => c.String(maxLength: 10));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.People", "PhoneNumber", c => c.Long(nullable: false));
        }
    }
}
