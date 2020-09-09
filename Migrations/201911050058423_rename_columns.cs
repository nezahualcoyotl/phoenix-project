namespace BackstageMusic.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class rename_columns : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Invitations", name: "invitee", newName: "id_invitee");
            RenameColumn(table: "dbo.Invitations", name: "inviter", newName: "id_inviter");
            RenameColumn(table: "dbo.Notifications", name: "receiver", newName: "id_receiver");
            RenameColumn(table: "dbo.Notifications", name: "sender", newName: "id_sender");
            RenameIndex(table: "dbo.Invitations", name: "IX_inviter", newName: "IX_id_inviter");
            RenameIndex(table: "dbo.Invitations", name: "IX_invitee", newName: "IX_id_invitee");
            RenameIndex(table: "dbo.Notifications", name: "IX_sender", newName: "IX_id_sender");
            RenameIndex(table: "dbo.Notifications", name: "IX_receiver", newName: "IX_id_receiver");
        }

        public override void Down()
        {
            RenameIndex(table: "dbo.Notifications", name: "IX_id_receiver", newName: "IX_receiver");
            RenameIndex(table: "dbo.Notifications", name: "IX_id_sender", newName: "IX_sender");
            RenameIndex(table: "dbo.Invitations", name: "IX_id_invitee", newName: "IX_invitee");
            RenameIndex(table: "dbo.Invitations", name: "IX_id_inviter", newName: "IX_inviter");
            RenameColumn(table: "dbo.Notifications", name: "id_sender", newName: "sender");
            RenameColumn(table: "dbo.Notifications", name: "id_receiver", newName: "receiver");
            RenameColumn(table: "dbo.Invitations", name: "id_inviter", newName: "inviter");
            RenameColumn(table: "dbo.Invitations", name: "id_invitee", newName: "invitee");
        }
    }
}
