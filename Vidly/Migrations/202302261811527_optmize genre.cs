namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class optmizegenre : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Movies", name: "Genre_Id", newName: "MovieGenre_Id");
            RenameIndex(table: "dbo.Movies", name: "IX_Genre_Id", newName: "IX_MovieGenre_Id");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Movies", name: "IX_MovieGenre_Id", newName: "IX_Genre_Id");
            RenameColumn(table: "dbo.Movies", name: "MovieGenre_Id", newName: "Genre_Id");
        }
    }
}
