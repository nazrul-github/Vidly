namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangingDatatypeOfMembershiptypes : DbMigration
    {
        public override void Up()
        {
           
           
            AlterColumn("dbo.MembershipTypes", "SignUpFee", c => c.Int(nullable: false));
            AlterColumn("dbo.MembershipTypes", "DurationInMonths", c => c.Int(nullable: false));
            AlterColumn("dbo.MembershipTypes", "DiscountRate", c => c.Int(nullable: false));
           
        }
        
        public override void Down()
        {
           
            AlterColumn("dbo.MembershipTypes", "DiscountRate", c => c.Byte(nullable: false));
            AlterColumn("dbo.MembershipTypes", "DurationInMonths", c => c.Byte(nullable: false));
            AlterColumn("dbo.MembershipTypes", "SignUpFee", c => c.Byte(nullable: false));
           
        }
    }
}
