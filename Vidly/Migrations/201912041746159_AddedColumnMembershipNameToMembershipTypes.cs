namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedColumnMembershipNameToMembershipTypes : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MembershipTypes", "MembershipName", c => c.String(nullable:false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.MembershipTypes", "MembershipName");
        }
    }
}
