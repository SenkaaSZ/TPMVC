namespace TPLOCAL1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateMigration : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Avis", "Avis_Id", "dbo.Avis");
            DropIndex("dbo.Avis", new[] { "Avis_Id" });
            DropColumn("dbo.Avis", "Avis_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Avis", "Avis_Id", c => c.Int());
            CreateIndex("dbo.Avis", "Avis_Id");
            AddForeignKey("dbo.Avis", "Avis_Id", "dbo.Avis", "Id");
        }
    }
}
