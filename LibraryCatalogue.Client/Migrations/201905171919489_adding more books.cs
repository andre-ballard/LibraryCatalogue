namespace LibraryCatalogue.Client.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addingmorebooks : DbMigration
    {
        public override void Up()
        {
            Sql("insert into Books (Author, Publisher, Title, Subject, Edition, Discriminator) values ('Mark Twain', 'American Publishing Company', 'Roughing It', 'Travel literature','I', '')");
            //Sql("insert into Books (Author, Publisher, Title, Subject, Edition, Discriminator) values ('Stephen King', 'Charles Scribner's Sons', 'Elavation', 'Travel literature','I', '')");
            //Sql("insert into Books (Author, Publisher, Title, Subject, Edition, Discriminator) values ('Stephen King', 'NAL', 'Thinner', 'Horror','I', '')");
            //Sql("insert into Books (Author, Publisher, Title, Subject, Edition, Discriminator) values ('Ernest Hemingway', 'Charles Scribner's Sons', 'Green Hills of Africa', 'Fiction','I', '')");
        }
        
        public override void Down()
        {
        }
    }
}
