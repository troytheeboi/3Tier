using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Infrastructure.DB_Contexts 
{
    public class MyDbContext : DbContext
    {
        public DbSet<ProductEntity> Products { get; set; }

        public DbSet<SupplierEntity> Suppliers { get; set; }

        public DbSet<CategoryEntity> Categories { get; set; }

        public DbSet<OrderEntity> Orders { get; set; }

        public DbSet<CustomerEntity> Customers { get; set; }

        public DbSet<BranchEntity?> branches { get; set; }

        public DbSet<EmployeeEntity> employees { get; set; }

        public DbSet<PaymentEntity> payments { get; set; }

        public DbSet<ReviewEntity> reviews { get; set; }

        public DbSet<ShoppingCartEntity> shoppingCarts { get; set; }
        
        public MyDbContext()
        {
        }
        
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
        }

        
       protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            IConfigurationBuilder builder = new ConfigurationBuilder().AddJsonFile("config.json", false, true);
            IConfigurationRoot root = builder.Build();
            optionsBuilder.UseNpgsql(root.GetConnectionString("PostgreConnectionString"));
        }
    }
}
