namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class datenull : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Movies", "ReleaseDate", c => c.DateTime());
            AlterColumn("dbo.Movies", "addingDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Movies", "addingDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Movies", "ReleaseDate", c => c.DateTime(nullable: false));
        }
    }
}
