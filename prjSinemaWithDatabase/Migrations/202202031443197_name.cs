namespace prjSinemaWithDatabase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class name : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Films", "Musteri_ID", "dbo.Musteris");
            DropIndex("dbo.Films", new[] { "Musteri_ID" });
            DropColumn("dbo.Films", "Musteri_ID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Films", "Musteri_ID", c => c.Int());
            CreateIndex("dbo.Films", "Musteri_ID");
            AddForeignKey("dbo.Films", "Musteri_ID", "dbo.Musteris", "ID");
        }
    }
}
