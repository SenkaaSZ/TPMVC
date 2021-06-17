namespace TPLOCAL1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.FormulaireModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nom = c.String(nullable: false),
                        Prenom = c.String(nullable: false),
                        Sexe = c.String(nullable: false),
                        Adresse = c.String(nullable: false),
                        Codepostal = c.Int(nullable: false),
                        Ville = c.String(nullable: false),
                        Adressemail = c.String(nullable: false),
                        DateFormation = c.DateTime(nullable: false),
                        Formation = c.String(nullable: false),
                        Cobol = c.String(nullable: false),
                        Objet = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.FormulaireModels");
        }
    }
}
