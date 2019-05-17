namespace LibraryCatalogue.Client.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addmorebooks : DbMigration
    {
        public override void Up()
        {
            Sql("insert into Books (Author, Publisher, Title, Subject, Edition, Discriminator) values ('Madeleine L Engle', 'Ariel Books', 'A Wrinkle in Time', 'Young Adult','I', 'Book')");
            Sql("insert into Books (Author, Publisher, Title, Subject, Edition, Discriminator) values ('Madeleine L Engle', 'Farrar, Straus & Giroux', 'The Arm of the Starfish ', 'Young Adult Science fiction','I', 'Book')");
            Sql("insert into Books (Author, Publisher, Title, Subject, Edition, Discriminator) values ('Madeleine L Engle', 'Ariel Books', 'A Live Coal in the Sea ', 'Young Adult Science fiction','I', 'Book')");
        }
        
        public override void Down()
        {
        }
    }
}
