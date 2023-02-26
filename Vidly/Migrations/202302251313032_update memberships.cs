namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatememberships : DbMigration
    {
        public override void Up()
        {
	        Sql("INSERT INTO MemberShipTypes VALUES ('Basic',10,1,5)");
			Sql("INSERT INTO MemberShipTypes VALUES ('Plus',19,3,15)");
	        Sql("INSERT INTO MemberShipTypes VALUES ('Pro',29,6,30)");
	        Sql("INSERT INTO MemberShipTypes VALUES ('Enterprice',99,12,50)");
		}
        
        public override void Down()
        {
        }
    }
}
