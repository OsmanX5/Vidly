namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seedingmoviesgenres : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MovieGenres VALUES('Comady')");
            Sql("INSERT INTO MovieGenres VALUES('Action')");
            Sql("INSERT INTO MovieGenres VALUES('Drama')");
            Sql("INSERT INTO MovieGenres VALUES('SciFi')");
		}
        
        public override void Down()
        {
        }
    }
}
