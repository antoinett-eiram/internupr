namespace internUPR.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Internships", "name", c => c.String());
            AddColumn("dbo.Internships", "userId", c => c.String(maxLength: 128));
            AddColumn("dbo.AspNetUsers", "fullName", c => c.String());
            CreateIndex("dbo.Internships", "userId");
            AddForeignKey("dbo.Internships", "userId", "dbo.AspNetUsers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Internships", "userId", "dbo.AspNetUsers");
            DropIndex("dbo.Internships", new[] { "userId" });
            DropColumn("dbo.AspNetUsers", "fullName");
            DropColumn("dbo.Internships", "userId");
            DropColumn("dbo.Internships", "name");
        }
    }
}
