namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddKeyMoviegenre : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "MoviesGenreId", c => c.Byte(nullable: false));
            AddColumn("dbo.Movies", "MoviesGenre_Id", c => c.Int());
            CreateIndex("dbo.Movies", "MoviesGenre_Id");
            AddForeignKey("dbo.Movies", "MoviesGenre_Id", "dbo.MoviesGenres", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Movies", "MoviesGenre_Id", "dbo.MoviesGenres");
            DropIndex("dbo.Movies", new[] { "MoviesGenre_Id" });
            DropColumn("dbo.Movies", "MoviesGenre_Id");
            DropColumn("dbo.Movies", "MoviesGenreId");
        }
    }
}
