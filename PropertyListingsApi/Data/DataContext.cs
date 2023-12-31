﻿
namespace PropertyListingsApi.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) :base(options)
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=.\\SQLExpress; Database=PropertyListings; Trusted_Connection=true; TrustServerCertificate=true;");
        }

        public DbSet<Listing> Listings { get; set; }

    }
}
