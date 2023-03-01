namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedMembershipTypes : DbMigration
    {
        public override void Up()
        {
			Sql("INSERT INTO MemberShipTypes " +
			    "VALUES ('Basic' ,0, 1,0)");
			Sql("INSERT INTO MemberShipTypes " +
			    "VALUES ('Plus'   ,9, 3,20)");
			Sql("INSERT INTO MemberShipTypes " +
			    "VALUES ('Pro'    ,19, 6,40)");
			Sql("INSERT INTO MemberShipTypes " +
			    "VALUES ('Enterprise' ,49, 12,70)");
        }

		public override void Down()
        {
        }
    }
}
