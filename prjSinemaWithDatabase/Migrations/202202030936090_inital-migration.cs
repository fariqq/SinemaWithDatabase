namespace prjSinemaWithDatabase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initalmigration : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Films", "kategori_ID", "dbo.Kategoris");
            DropIndex("dbo.Films", new[] { "kategori_ID" });
            RenameColumn(table: "dbo.Films", name: "kategori_ID", newName: "KategoriId");
            AlterColumn("dbo.Films", "KategoriId", c => c.Int(nullable: false));
            CreateIndex("dbo.Films", "KategoriId");
            AddForeignKey("dbo.Films", "KategoriId", "dbo.Kategoris", "ID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Films", "KategoriId", "dbo.Kategoris");
            DropIndex("dbo.Films", new[] { "KategoriId" });
            AlterColumn("dbo.Films", "KategoriId", c => c.Int());
            RenameColumn(table: "dbo.Films", name: "KategoriId", newName: "kategori_ID");
            CreateIndex("dbo.Films", "kategori_ID");
            AddForeignKey("dbo.Films", "kategori_ID", "dbo.Kategoris", "ID");
        }
    }
}
