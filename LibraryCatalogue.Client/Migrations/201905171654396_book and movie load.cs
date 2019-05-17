namespace LibraryCatalogue.Client.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class bookandmovieload : DbMigration
    {
        public override void Up()
        {
            Sql("insert into Movies (Director, Length, Title, Subject) values ('Martin Scorsese', 96, 'Taxi Driver', 'Action')");
            Sql("insert into Movies (Director, Length, Title, Subject) values ('Martin Scorsese', 96, 'GoodFellas', 'Drama')");
            Sql("insert into Movies (Director, Length, Title, Subject) values ('Steven Allen', 110, 'Jurassic Park', 'Sci-Fi')");
            Sql("insert into Movies (Director, Length, Title, Subject) values ('Steven Allen', 105, 'Duel', 'Action')");

            
           
        }
        
        public override void Down()
        {
        }
    }
}
