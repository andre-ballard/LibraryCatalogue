namespace LibraryCatalogue.Client.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class removedmagazinesandbooks : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.Books");
        }
        
        public override void Down()
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
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id);
            
        }
    }
}
