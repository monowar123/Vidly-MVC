namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatemembershipType : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MembershipTypes SET name = 'Pay as you go' where id = 1");
            Sql("UPDATE MembershipTypes SET name = 'Monthly' where id = 2");
            Sql("UPDATE MembershipTypes SET name = 'Quarterly' where id = 3");
            Sql("UPDATE MembershipTypes SET name = 'Yearly' where id = 4");
        }
        
        public override void Down()
        {
        }
    }
}
