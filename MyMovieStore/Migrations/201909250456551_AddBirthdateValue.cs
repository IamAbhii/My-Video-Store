namespace MyMovieStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBirthdateValue : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.MembershipTypes", "Name", c => c.String(nullable: false));
            Sql("Update Customers SET Birthdate='1990-05-22 12:12:12' Where Id=1");
            Sql("Update Customers SET Birthdate='1993-02-10 12:12:12' Where Id=3");
            Sql("Update Customers SET Birthdate='1990-11-07 12:12:12' Where Id=4");
        }
        
        public override void Down()
        {
            AlterColumn("dbo.MembershipTypes", "Name", c => c.String());
        }
    }
}
