namespace LibraryCatalogue.Client.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class loadmoviedata : DbMigration
    {
        public override void Up()
        {
            Sql("insert into Movies (Director, Length, Title, Subject) values ('John Singleton', 96, '2FAST2FURIOS', 'Action')");
            Sql("insert into Movies (Director, Length, Title, Subject) values ('John Singleton', 96, 'BABYBOY', 'Drama')");
            Sql("insert into Movies (Director, Length, Title, Subject) values ('Steven Allen', 110, 'E.T. the Extra-Terrestrial', 'Sci-Fi')");
            Sql("insert into Movies (Director, Length, Title, Subject) values ('Steven Allen', 105, 'Jaws', 'Action')");
        }
        
        public override void Down()
        {
        }
    }
}
