namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMovies : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies (Name, Genre, ReleaseDate, DateAdded, NumberInStock)" +
                " VALUES ('Hangover', 'Comedy', '1990-02-15', '2020-05-11', 1)");
            Sql("INSERT INTO Movies (Name, Genre, ReleaseDate, DateAdded, NumberInStock)" +
                " VALUES ('Die Hard', 'Action', '1995-04-20', '2020-05-11', 5)"); 
            Sql("INSERT INTO Movies (Name, Genre, ReleaseDate, DateAdded, NumberInStock)" +
                 " VALUES ('The Terminator', 'Action', '2000-02-15', '2020-05-11', 4)");
            Sql("INSERT INTO Movies (Name, Genre, ReleaseDate, DateAdded, NumberInStock)" +
                " VALUES ('Titanic', 'Romance', '1991-02-18', '2020-05-11', 1)");
            Sql("INSERT INTO Movies (Name, Genre, ReleaseDate, DateAdded, NumberInStock)" +
                " VALUES ('Toy Story', 'Family', '2018-02-15', '2020-05-11', 4)");
        }
        
        public override void Down()
        {
        }
    }
}
