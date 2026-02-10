namespace G_StudentManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTeacherToScore : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Scores", "TeacherId", c => c.Int(nullable: false));
            CreateIndex("dbo.Scores", "TeacherId");
            AddForeignKey("dbo.Scores", "TeacherId", "dbo.Teachers", "TeacherId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Scores", "TeacherId", "dbo.Teachers");
            DropIndex("dbo.Scores", new[] { "TeacherId" });
            DropColumn("dbo.Scores", "TeacherId");
        }
    }
}
