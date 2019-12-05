namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addingNewMoveis : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies VALUES('Hangover','1')");
            Sql("INSERT INTO Movies VALUES('Die Hard','2')");
            Sql("INSERT INTO Movies VALUES('The Terminator','2')");
            Sql("INSERT INTO Movies VALUES('Toy Story','3')");
            Sql("INSERT INTO Movies VALUES('Titanic','4')");
        }
        
        public override void Down()
        {
        }
    }
}
