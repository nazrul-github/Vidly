namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class settingVelueForBirthdate : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET BirthDate = '1992-12-16' WHERE Id = 1");
        }
        
        public override void Down()
        {
        }
    }
}
