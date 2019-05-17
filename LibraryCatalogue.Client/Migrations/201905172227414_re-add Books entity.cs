namespace LibraryCatalogue.Client.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class readdBooksentity : DbMigration
    {
        public override void Up()
        {
            /*CreateTable(
                "dbo.Books",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Author = c.String(),
                    Publisher = c.String(),
                    Title = c.String(),
                    Subject = c.String(),
                    Edition = c.String(),
                    Discriminator = c.String(nullable: false, maxLength: 128),
                })
                .PrimaryKey(t => t.Id);*/
            Sql("insert into Books (Author, Publisher, Title, Subject, Edition, Discriminator) values ('Mark Twain', 'Chatto & Windus / Charles L. Webster And Company', 'The Adventures of Huckleberry Finn', 'Picaresque novel','II', 'Book')");
            Sql("insert into Books (Author, Publisher, Title, Subject, Edition, Discriminator) values ('Mark Twain', 'James R. Osgood & Co., Boston', 'Life on the Mississippi', 'Biography','I', 'Book')");
            Sql("insert into Books (Author, Publisher, Title, Subject, Edition, Discriminator) values ('Mark Twain', 'American Publishing Company', 'Roughing It', 'Travel literature','I', 'Book')");
            Sql("insert into Books (Author, Publisher, Title, Subject, Edition, Discriminator) values ('Stephen King', 'NAL', 'Thinner', 'Horror','I', 'Book')");
        }

        public override void Down()
        {
            DropTable("dbo.Books");
        }
    }
}
