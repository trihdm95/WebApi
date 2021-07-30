using Microsoft.EntityFrameworkCore;
using WebApiService.Entities.Entity;

namespace WebApiService.Entities
{
    public class DatabaseContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<City> Cites { get; set; }
        public DbSet<ActivateOnlineDetail> ActivateOnlineDetails { get; set; }
        public DbSet<InvoiceDetail> InvoiceDetails { get; set; }
        public DbSet<ActivateOnlineSubdealerDetail> ActivateOnlineSubdealerDetails { get; set; }
        public DbSet<ExtendActivation> ExtendActivations { get; set; }
        public DbSet<BonusConfig> BonusConfigs { get; set; }
        public DbSet<ActivateOnline> ActivateOnlines { get; set; }
        public DbSet<WalletHistory> WalletHistories { get; set; }
        public DbSet<Wallet> Wallets { get; set; }
        public DbSet<PosCode> PosCodes { get; set; }

        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }
    }
}
