namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class memberships : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MemberShipTypes VALUES ('Basic',10,1,5)");

		}
        
        public override void Down()
        {
        }
    }
}
