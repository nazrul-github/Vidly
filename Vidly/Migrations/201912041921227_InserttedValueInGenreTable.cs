namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InserttedValueInGenreTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres VALUES('Comedy')");
        }
        
        public override void Down()
        {
        }
    }
}
