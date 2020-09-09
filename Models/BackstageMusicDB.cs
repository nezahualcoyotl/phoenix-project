namespace BackstageMusic.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using System.Threading.Tasks;

    public class BackstageMusicDB : DbContext
    {
        public BackstageMusicDB() : base("name=BackstageMusicDB")
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<BackstageMusicDB>());
        }

        //Catalogs
        public DbSet<Continent> Continents { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Platform> Platforms { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Status> Status { get; set; }
        public DbSet<UserType> UserTypes { get; set; }
        public DbSet<AssetType> AssetTypes { get; set; }
        public DbSet<CollaboratorType> CollaboratorTypes { get; set; }
        //Core catalogs
        public DbSet<User> Users { get; set; }
        public DbSet<Label> Labels { get; set; }
        public DbSet<Manager> Managers { get; set; }
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Asset> Assets { get; set; }
        public DbSet<Track> Tracks { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<Invitation> Invitations { get; set; }
        //Relational tables
        public DbSet<AssetCountry> AssetCountries { get; set; }
        public DbSet<AssetGenre> AssetGenres { get; set; }
        public DbSet<AssetPlatform> AssetPlatforms { get; set; }
        public DbSet<Collaboration> Collaborations { get; set; }
        public DbSet<Admin> Admins { get; set; }

        public override int SaveChanges()
        {
            AddTimestamps();
            return base.SaveChanges();
        }

        public override async Task<int> SaveChangesAsync()
        {
            AddTimestamps();
            return await base.SaveChangesAsync();
        }

        private void AddTimestamps()
        {
            var entities = ChangeTracker.Entries().Where(x => x.Entity is BaseEntity && (x.State == EntityState.Added || x.State == EntityState.Modified));

            foreach (var entity in entities)
            {
                if (entity.State == EntityState.Added)
                {
                    ((BaseEntity)entity.Entity).created_at = DateTime.UtcNow;
                }

                ((BaseEntity)entity.Entity).updated_at = DateTime.UtcNow;
            }
        }
    }

}