namespace BackstageMusic.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class create_core_tables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Assets",
                c => new
                {
                    id_asset = c.Int(nullable: false, identity: true),
                    id_artist = c.Int(nullable: false),
                    id_assettype = c.Int(nullable: false),
                    id_language = c.Int(nullable: false),
                    id_status = c.Int(nullable: false),
                    id_orderdetail = c.Int(nullable: false),
                    asset_guid = c.Guid(nullable: false),
                    name = c.String(nullable: false),
                    copy_holder = c.String(nullable: false),
                    copy_year = c.Int(nullable: false),
                    image_version = c.Int(nullable: false),
                    upc = c.String(),
                    is_explicit = c.Boolean(nullable: false),
                    is_debut = c.String(nullable: false),
                    price = c.Decimal(nullable: false, precision: 18, scale: 2),
                    received_on = c.DateTime(),
                    approved_on = c.DateTime(),
                    released_on = c.DateTime(),
                    rejected_on = c.DateTime(),
                    active = c.Boolean(nullable: false, defaultValue: true),
                    created_at = c.DateTime(defaultValueSql: "GETDATE()"),
                    updated_at = c.DateTime(),
                })
                .PrimaryKey(t => t.id_asset)
                .ForeignKey("dbo.Artists", t => t.id_artist, cascadeDelete: true)
                .ForeignKey("dbo.AssetTypes", t => t.id_assettype, cascadeDelete: true)
                .ForeignKey("dbo.Languages", t => t.id_language, cascadeDelete: true)
                .ForeignKey("dbo.OrderDetails", t => t.id_orderdetail, cascadeDelete: true)
                .ForeignKey("dbo.Status", t => t.id_status, cascadeDelete: true)
                .Index(t => t.id_artist)
                .Index(t => t.id_assettype)
                .Index(t => t.id_language)
                .Index(t => t.id_status)
                .Index(t => t.id_orderdetail);

            CreateTable(
                "dbo.Artists",
                c => new
                {
                    id_artist = c.Int(nullable: false, identity: true),
                    name = c.String(nullable: false),
                    id_user = c.Int(nullable: false),
                    id_manager = c.Int(nullable: false),
                    active = c.Boolean(nullable: false, defaultValue: true),
                    created_at = c.DateTime(defaultValueSql: "GETDATE()"),
                    updated_at = c.DateTime(),
                })
                .PrimaryKey(t => t.id_artist)
                .ForeignKey("dbo.Managers", t => t.id_manager, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.id_user, cascadeDelete: false)
                .Index(t => t.id_user)
                .Index(t => t.id_manager);

            CreateTable(
                "dbo.Managers",
                c => new
                {
                    id_manager = c.Int(nullable: false, identity: true),
                    name = c.String(nullable: false),
                    id_user = c.Int(nullable: false),
                    id_label = c.Int(nullable: false),
                    active = c.Boolean(nullable: false, defaultValue: true),
                    created_at = c.DateTime(defaultValueSql: "GETDATE()"),
                    updated_at = c.DateTime(),
                })
                .PrimaryKey(t => t.id_manager)
                .ForeignKey("dbo.Labels", t => t.id_label, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.id_user, cascadeDelete: false)
                .Index(t => t.id_user)
                .Index(t => t.id_label);

            CreateTable(
                "dbo.Labels",
                c => new
                {
                    id_label = c.Int(nullable: false, identity: true),
                    name = c.String(nullable: false),
                    id_user = c.Int(nullable: false),
                    active = c.Boolean(nullable: false, defaultValue: true),
                    created_at = c.DateTime(defaultValueSql: "GETDATE()"),
                    updated_at = c.DateTime(),
                })
                .PrimaryKey(t => t.id_label)
                .ForeignKey("dbo.Users", t => t.id_user, cascadeDelete: false)
                .Index(t => t.id_user);

            CreateTable(
                "dbo.Users",
                c => new
                {
                    id_user = c.Int(nullable: false, identity: true),
                    name = c.String(nullable: false),
                    password = c.String(nullable: false),
                    email = c.String(nullable: false),
                    id_type = c.Int(nullable: false),
                    is_suscribed = c.Boolean(nullable: false),
                    is_confirmed = c.Boolean(nullable: false),
                    primary_address = c.String(nullable: false),
                    secondary_address = c.String(),
                    city = c.String(nullable: false),
                    zipcode = c.Int(nullable: false),
                    id_country = c.Int(nullable: false),
                    voucher = c.String(nullable: false),
                    active = c.Boolean(nullable: false, defaultValue: true),
                    created_at = c.DateTime(defaultValueSql: "GETDATE()"),
                    updated_at = c.DateTime(),
                })
                .PrimaryKey(t => t.id_user)
                .ForeignKey("dbo.Countries", t => t.id_country, cascadeDelete: true)
                .ForeignKey("dbo.UserTypes", t => t.id_type, cascadeDelete: true)
                .Index(t => t.id_type)
                .Index(t => t.id_country);

            CreateTable(
                "dbo.OrderDetails",
                c => new
                {
                    id_orderdetail = c.Int(nullable: false, identity: true),
                    id_order = c.Int(nullable: false),
                    id_product = c.Int(nullable: false),
                    active = c.Boolean(nullable: false, defaultValue: true),
                    created_at = c.DateTime(defaultValueSql: "GETDATE()"),
                    updated_at = c.DateTime(),
                })
                .PrimaryKey(t => t.id_orderdetail)
                .ForeignKey("dbo.Orders", t => t.id_order, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.id_product, cascadeDelete: true)
                .Index(t => t.id_order)
                .Index(t => t.id_product);

            CreateTable(
                "dbo.Orders",
                c => new
                {
                    id_order = c.Int(nullable: false, identity: true),
                    id_payment = c.Int(nullable: false),
                    id_user = c.Int(nullable: false),
                    active = c.Boolean(nullable: false, defaultValue: true),
                    created_at = c.DateTime(defaultValueSql: "GETDATE()"),
                    updated_at = c.DateTime(),
                })
                .PrimaryKey(t => t.id_order)
                .ForeignKey("dbo.Payments", t => t.id_payment, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.id_user, cascadeDelete: true)
                .Index(t => t.id_payment)
                .Index(t => t.id_user);

            CreateTable(
                "dbo.Payments",
                c => new
                {
                    id_payment = c.Int(nullable: false, identity: true),
                    voucher = c.String(nullable: false),
                    transaction_id = c.String(nullable: false),
                    payment_status = c.String(nullable: false),
                    payment_amount = c.String(nullable: false),
                    currency = c.String(nullable: false),
                    active = c.Boolean(nullable: false, defaultValue: true),
                    created_at = c.DateTime(defaultValueSql: "GETDATE()"),
                    updated_at = c.DateTime(),
                })
                .PrimaryKey(t => t.id_payment);

            CreateTable(
                "dbo.Invitations",
                c => new
                {
                    id_invitation = c.Int(nullable: false, identity: true),
                    inviter = c.Int(nullable: false),
                    invitee = c.Int(nullable: false),
                    accepted_on = c.DateTime(),
                    active = c.Boolean(nullable: false, defaultValue: true),
                    created_at = c.DateTime(defaultValueSql: "GETDATE()"),
                    updated_at = c.DateTime(),
                })
                .PrimaryKey(t => t.id_invitation)
                .ForeignKey("dbo.Users", t => t.invitee, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.inviter, cascadeDelete: false)
                .Index(t => t.inviter)
                .Index(t => t.invitee);

            CreateTable(
                "dbo.Notifications",
                c => new
                {
                    id_notification = c.Int(nullable: false, identity: true),
                    sender = c.Int(nullable: false),
                    receiver = c.Int(nullable: false),
                    message = c.String(nullable: false),
                    is_seen = c.Boolean(nullable: false),
                    active = c.Boolean(nullable: false, defaultValue: true),
                    created_at = c.DateTime(defaultValueSql: "GETDATE()"),
                    updated_at = c.DateTime(),
                })
                .PrimaryKey(t => t.id_notification)
                .ForeignKey("dbo.Users", t => t.receiver, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.sender, cascadeDelete: false)
                .Index(t => t.sender)
                .Index(t => t.receiver);

            CreateTable(
                "dbo.Tracks",
                c => new
                {
                    id_track = c.Int(nullable: false, identity: true),
                    id_asset = c.Int(nullable: false),
                    track_guid = c.Guid(nullable: false),
                    name = c.String(nullable: false),
                    file_name = c.String(nullable: false),
                    track_number = c.Int(nullable: false),
                    is_explicit = c.Boolean(nullable: false),
                    isrc = c.String(nullable: false),
                    active = c.Boolean(nullable: false, defaultValue: true),
                    created_at = c.DateTime(defaultValueSql: "GETDATE()"),
                    updated_at = c.DateTime(),
                })
                .PrimaryKey(t => t.id_track)
                .ForeignKey("dbo.Assets", t => t.id_asset, cascadeDelete: true)
                .Index(t => t.id_asset);

        }

        public override void Down()
        {
            DropForeignKey("dbo.Tracks", "id_asset", "dbo.Assets");
            DropForeignKey("dbo.Notifications", "sender", "dbo.Users");
            DropForeignKey("dbo.Notifications", "receiver", "dbo.Users");
            DropForeignKey("dbo.Invitations", "inviter", "dbo.Users");
            DropForeignKey("dbo.Invitations", "invitee", "dbo.Users");
            DropForeignKey("dbo.Assets", "id_status", "dbo.Status");
            DropForeignKey("dbo.Assets", "id_orderdetail", "dbo.OrderDetails");
            DropForeignKey("dbo.OrderDetails", "id_product", "dbo.Products");
            DropForeignKey("dbo.OrderDetails", "id_order", "dbo.Orders");
            DropForeignKey("dbo.Orders", "id_user", "dbo.Users");
            DropForeignKey("dbo.Orders", "id_payment", "dbo.Payments");
            DropForeignKey("dbo.Assets", "id_language", "dbo.Languages");
            DropForeignKey("dbo.Assets", "id_assettype", "dbo.AssetTypes");
            DropForeignKey("dbo.Assets", "id_artist", "dbo.Artists");
            DropForeignKey("dbo.Artists", "id_user", "dbo.Users");
            DropForeignKey("dbo.Artists", "id_manager", "dbo.Managers");
            DropForeignKey("dbo.Managers", "id_user", "dbo.Users");
            DropForeignKey("dbo.Managers", "id_label", "dbo.Labels");
            DropForeignKey("dbo.Labels", "id_user", "dbo.Users");
            DropForeignKey("dbo.Users", "id_type", "dbo.UserTypes");
            DropForeignKey("dbo.Users", "id_country", "dbo.Countries");
            DropIndex("dbo.Tracks", new[] { "id_asset" });
            DropIndex("dbo.Notifications", new[] { "receiver" });
            DropIndex("dbo.Notifications", new[] { "sender" });
            DropIndex("dbo.Invitations", new[] { "invitee" });
            DropIndex("dbo.Invitations", new[] { "inviter" });
            DropIndex("dbo.Orders", new[] { "id_user" });
            DropIndex("dbo.Orders", new[] { "id_payment" });
            DropIndex("dbo.OrderDetails", new[] { "id_product" });
            DropIndex("dbo.OrderDetails", new[] { "id_order" });
            DropIndex("dbo.Users", new[] { "id_country" });
            DropIndex("dbo.Users", new[] { "id_type" });
            DropIndex("dbo.Labels", new[] { "id_user" });
            DropIndex("dbo.Managers", new[] { "id_label" });
            DropIndex("dbo.Managers", new[] { "id_user" });
            DropIndex("dbo.Artists", new[] { "id_manager" });
            DropIndex("dbo.Artists", new[] { "id_user" });
            DropIndex("dbo.Assets", new[] { "id_orderdetail" });
            DropIndex("dbo.Assets", new[] { "id_status" });
            DropIndex("dbo.Assets", new[] { "id_language" });
            DropIndex("dbo.Assets", new[] { "id_assettype" });
            DropIndex("dbo.Assets", new[] { "id_artist" });
            DropTable("dbo.Tracks");
            DropTable("dbo.Notifications");
            DropTable("dbo.Invitations");
            DropTable("dbo.Payments");
            DropTable("dbo.Orders");
            DropTable("dbo.OrderDetails");
            DropTable("dbo.Users");
            DropTable("dbo.Labels");
            DropTable("dbo.Managers");
            DropTable("dbo.Artists");
            DropTable("dbo.Assets");
        }
    }
}
