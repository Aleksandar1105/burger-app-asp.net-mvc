namespace BurgerApp.DataAccess.DataContext
{
    using BurgerApp.Domain.Models;
    using Microsoft.EntityFrameworkCore;
    public class BurgerAppDbContext : DbContext
    {
        public BurgerAppDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {

        }

        public DbSet<Burger> Burgers { get; set; }
        public DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Order>()
                .HasMany(x => x.BurgerOrders)
                .WithOne(x => x.Order)
                .HasForeignKey(x => x.OrderId);

            modelBuilder.Entity<Burger>()
                .HasMany(x => x.BurgerOrders)
                .WithOne(x => x.Burger)
                .HasForeignKey(x => x.BurgerId);

            modelBuilder.Entity<Burger>()
                .HasData(
                new Burger()
                {
                    Id = 1,
                    Name = "Classic Cheeseburger",
                    Price = 180,
                    IsVegetarian = false,
                    IsVegan = false,
                    HasFries = true
                },
                new Burger()
                {
                    Id = 2,
                    Name = "Veggie Burger",
                    Price = 200,
                    IsVegetarian = true,
                    IsVegan = false,
                    HasFries = true
                },
                new Burger()
                {
                    Id = 3,
                    Name = "Beyond Burger",
                    Price = 220,
                    IsVegetarian = false,
                    IsVegan = true,
                    HasFries = true
                },
                new Burger()
                {
                    Id = 4,
                    Name = "Bacon Cheeseburger",
                    Price = 240,
                    IsVegetarian = false,
                    IsVegan = false,
                    HasFries = true
                },
                new Burger()
                {
                    Id = 5,
                    Name = "Mushroom Swiss Burger",
                    Price = 260,
                    IsVegetarian = false,
                    IsVegan = false,
                    HasFries = false
                });

            modelBuilder.Entity<Order>()
                .HasData(
                new Order()
                {
                    Id = 1,
                    FullName = "John Doe",
                    Address = "123 Main St",
                    IsDelivered = false,
                    LocationId = 1
                },
                new Order()
                {
                    Id = 2,
                    FullName = "Jane Smith",
                    Address = "789 Oak St",
                    IsDelivered = true,
                    LocationId = 2
                },
                new Order()
                {
                    Id = 3,
                    FullName = "Alice Johnson",
                    Address = "456 Pine St",
                    IsDelivered = true,
                    LocationId = 3
                },
                new Order()
                {
                    Id = 4,
                    FullName = "Michael Davis",
                    Address = "987 Walnut Ln",
                    IsDelivered = false,
                    LocationId = 4
                },
                new Order()
                {
                    Id = 5,
                    FullName = "Sarah Wilson",
                    Address = "321 Elm St",
                    IsDelivered = false,
                    LocationId = 5
                });

            modelBuilder.Entity<BurgerOrder>()
                .HasData(
                new BurgerOrder()
                {
                    Id = 1,
                    BurgerId = 1,
                    OrderId = 1,
                },
                new BurgerOrder()
                {
                    Id = 2,
                    BurgerId = 2,
                    OrderId = 1,
                },
                new BurgerOrder()
                {
                    Id = 3,
                    BurgerId = 1,
                    OrderId = 2,
                },
                new BurgerOrder()
                {
                    Id = 4,
                    BurgerId = 3,
                    OrderId = 3,
                },
                new BurgerOrder()
                {
                    Id = 5,
                    BurgerId = 2,
                    OrderId = 4,
                });

            modelBuilder.Entity<Location>()
                .HasData(
                new Location()
                {
                    Id = 1,
                    Name = "Burger Palace",
                    Address = "456 Elm St",
                    OpensAt = TimeSpan.FromHours(10),
                    ClosesAt = TimeSpan.FromHours(21)
                },
                new Location()
                {
                    Id = 2,
                    Name = "Burger Kingdom",
                    Address = "321 Maple Ave",
                    OpensAt = TimeSpan.FromHours(9),
                    ClosesAt = TimeSpan.FromHours(20)
                },
                new Location()
                {
                    Id = 3,
                    Name = "Burger Spot",
                    Address = "789 Cedar Rd",
                    OpensAt = TimeSpan.FromHours(8),
                    ClosesAt = TimeSpan.FromHours(22)
                },
                new Location()
                {
                    Id = 4,
                    Name = "Burger Hub",
                    Address = "654 Cherry St",
                    OpensAt = TimeSpan.FromHours(11),
                    ClosesAt = TimeSpan.FromHours(23)
                },
                new Location()
                {
                    Id = 5,
                    Name = "Burger Joint",
                    Address = "456 Oak St",
                    OpensAt = TimeSpan.FromHours(10),
                    ClosesAt = TimeSpan.FromHours(20)
                });
        }
    }
}
