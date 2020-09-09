namespace BackstageMusic.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class usertypecolumnnamecorrected : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Users", name: "id_type", newName: "id_usertype");
            RenameIndex(table: "dbo.Users", name: "IX_id_type", newName: "IX_id_usertype");
        }

        public override void Down()
        {
            RenameIndex(table: "dbo.Users", name: "IX_id_usertype", newName: "IX_id_type");
            RenameColumn(table: "dbo.Users", name: "id_usertype", newName: "id_type");
        }
    }
}
