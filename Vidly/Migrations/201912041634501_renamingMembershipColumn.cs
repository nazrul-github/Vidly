namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class renamingMembershipColumn : DbMigration
    {
        public override void Up()
        {
            RenameColumn("Customers", "MemberShipTypeId", "MembershipId");
        }

        public override void Down()
        {
            RenameColumn("Customers", "MembershipId", "MemberShipTypeId");
        }
    }
}
