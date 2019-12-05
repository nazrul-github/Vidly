namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedGenreColumnConstraints : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Genres", "GenreName", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Genres", "GenreName", c => c.String());
        }
    }
}
