namespace MyMovieStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SetNameForMembershipType : DbMigration
    {
        public override void Up()
        {
            Sql("Update MembershipTypes SET Name= 'Pay as you Go' WHERE Id=1");
            Sql("Update MembershipTypes SET Name= 'Monthly' WHERE Id=2");
            Sql("Update MembershipTypes SET Name= 'Quarterly' WHERE Id=3");
            Sql("Update MembershipTypes SET Name= 'Annual' WHERE Id=4");
        }
        
        public override void Down()
        {
        }
    }
}
