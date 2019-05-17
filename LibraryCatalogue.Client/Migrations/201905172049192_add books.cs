namespace LibraryCatalogue.Client.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addbooks : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Author = c.String(),
                        Publisher = c.String(),
                        Title = c.String(),
                        Subject = c.String(),
                        Edition = c.String(),
                        Discriminator = c.String(nullable: true, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id);

            Sql("insert into Books (Author, Publisher, Title, Subject, Edition) values ('Mark Twain', 'Chatto & Windus / Charles L. Webster And Company', 'The Adventures of Huckleberry Finn', 'Picaresque novel','II')");

        }
        
        public override void Down()
        {
            DropTable("dbo.Books");
        }
    }
}
