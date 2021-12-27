namespace HastaneRandevuSistemiDataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initdb : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Doktors", newName: "Doktorlar");
            RenameTable(name: "dbo.Randevus", newName: "Randevular");
            RenameTable(name: "dbo.Hastas", newName: "Hastalar");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Hastalar", newName: "Hastas");
            RenameTable(name: "dbo.Randevular", newName: "Randevus");
            RenameTable(name: "dbo.Doktorlar", newName: "Doktors");
        }
    }
}
