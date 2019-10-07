namespace MyMovieStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulatingGenreClass : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (Id,Name) Values (1,'Action')");
            Sql("INSERT INTO Genres (Id,Name) Values (2,'Thriller')");
            Sql("INSERT INTO Genres (Id,Name) Values (3,'Comedy')");
            Sql("INSERT INTO Genres (Id,Name) Values (4,'Family')");
            Sql("INSERT INTO Genres (Id,Name) Values (5,'Romance')");
        }
        
        public override void Down()
        {
        }
    }
}
