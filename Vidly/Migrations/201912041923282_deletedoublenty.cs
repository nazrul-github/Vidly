namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deletedoublenty : DbMigration
    {
        public override void Up()
        {
            Sql("DELETE FROM Genres WHERE Id=5");
        }
        
        public override void Down()
        {
        }
    }
}
