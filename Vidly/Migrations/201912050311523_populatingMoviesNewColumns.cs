namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populatingMoviesNewColumns : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Movies SET ReleaseDate = '2009-06-15',DateAdded = GETDATE(), NumberInStock = 5 WHERE Id = 1");
            Sql("UPDATE Movies SET ReleaseDate = '1992-02-12',DateAdded = GETDATE(), NumberInStock = 3 WHERE Id = 2");
            Sql("UPDATE Movies SET ReleaseDate = '1990-01-15',DateAdded = GETDATE(), NumberInStock = 6 WHERE Id = 3");
            Sql("UPDATE Movies SET ReleaseDate = '2006-06-15',DateAdded = GETDATE(), NumberInStock = 2 WHERE Id = 4");
            Sql("UPDATE Movies SET ReleaseDate = '1998-06-15',DateAdded = GETDATE(), NumberInStock = 8 WHERE Id = 5");
        }
        
        public override void Down()
        {
        }
    }
}
