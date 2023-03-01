namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedGenres : DbMigration
    {
        public override void Up()
        {
			Sql("INSERT INTO MovieGenres " +
				"VALUES ('Action')");
			Sql("INSERT INTO MovieGenres " +
				"VALUES ('Comedy')");
			Sql("INSERT INTO MovieGenres " +
			    "VALUES ('Drama')");
			Sql("INSERT INTO MovieGenres " +
				"VALUES ('Sci-Fi')");
			Sql("INSERT INTO MovieGenres " +
			    "VALUES ('Criminal')");
		}
        
        public override void Down()
        {
        }
    }
}
