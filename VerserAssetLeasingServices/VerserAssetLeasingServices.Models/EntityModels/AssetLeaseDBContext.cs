using Microsoft.EntityFrameworkCore;
namespace VerserAssetLeasingServices.DBEntities.EntityModels
{
    public class AssetLeaseDBContext :DbContext
    {
        public AssetLeaseDBContext(DbContextOptions<AssetLeaseDBContext> connectionstring) :base(connectionstring){ }
        public DbSet<Assets> Assets { get; set; }
        public DbSet<Companies> Companies { get; set; }
        public DbSet<EndUsers> EndUsers { get; set; }
        public DbSet<Carriers> Carriers { get; set; }
        public DbSet<Colours> Colours { get; set; }
        public DbSet<DeviceCategories> DeviceCategories { get; set; }
        public DbSet<InventoryItems> InventoryItems { get; set; }
        public DbSet<OEMs> OEMs { get; set; }
        public DbSet<Plans> Plans { get; set; }
        public DbSet<LifecycleStatusSet> LifecycleStatusSet { get; set; }
        public DbSet<Contracts> Contracts { get; set; }
    }
}
