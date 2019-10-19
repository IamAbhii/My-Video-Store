namespace MyMovieStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedMovieCLassPropertyName : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "NumberInStock", c => c.Int(nullable: false));
            DropColumn("dbo.Movies", "NumberInStick");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Movies", "NumberInStick", c => c.Int(nullable: false));
            DropColumn("dbo.Movies", "NumberInStock");
        }
    }
}
