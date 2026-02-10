namespace G_StudentManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddScoreTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Scores",
                c => new
                    {
                        ScoreId = c.Int(nullable: false, identity: true),
                        StudentId = c.Int(nullable: false),
                        SubjectId = c.Int(nullable: false),
                        ScoreValue = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ExamDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.ScoreId)
                .ForeignKey("dbo.Students", t => t.StudentId, cascadeDelete: true)
                .ForeignKey("dbo.Subjects", t => t.SubjectId, cascadeDelete: true)
                .Index(t => t.StudentId)
                .Index(t => t.SubjectId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Scores", "SubjectId", "dbo.Subjects");
            DropForeignKey("dbo.Scores", "StudentId", "dbo.Students");
            DropIndex("dbo.Scores", new[] { "SubjectId" });
            DropIndex("dbo.Scores", new[] { "StudentId" });
            DropTable("dbo.Scores");
        }
    }
}
