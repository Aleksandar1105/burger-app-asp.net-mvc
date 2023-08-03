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
        public DbSet<Location> Locations { get; set; }

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

            modelBuilder.Entity<Location>()
                .HasMany(x => x.Orders)
                .WithOne(x => x.Location)
                .HasForeignKey(x => x.LocationId);

            modelBuilder.Entity<Burger>().HasData(
                new Burger { Id = 1, Name = "Classic Cheeseburger", Price = 180, IsVegetarian = false, IsVegan = false, HasFries = true, ImageUrl = "https://rhubarbandcod.com/wp-content/uploads/2022/06/The-Classic-Cheeseburger-1-500x500.jpg" },
                new Burger { Id = 2, Name = "Veggie Burger", Price = 200, IsVegetarian = true, IsVegan = false, HasFries = true, ImageUrl = "https://www.kitchensanctuary.com/wp-content/uploads/2019/05/Cheesy-Veggie-Burger-Square-1200-500x500.jpg" },
                new Burger { Id = 3, Name = "Beyond Burger", Price = 220, IsVegetarian = false, IsVegan = true, HasFries = true, ImageUrl = "https://www.vegangrocerystore.com.au/cdn/shop/products/beyondburger_d0846b9c-a82c-4eaa-9f19-ee0be12d6bbc_800x.jpg?v=1624689743" },
                new Burger { Id = 4, Name = "Bacon Cheeseburger", Price = 240, IsVegetarian = false, IsVegan = false, HasFries = true, ImageUrl = "https://simply-delicious-food.com/wp-content/uploads/2015/07/Bacon-and-cheese-burgers-3.jpg" },
                new Burger { Id = 5, Name = "Mushroom Swiss Burger", Price = 260, IsVegetarian = false, IsVegan = false, HasFries = false, ImageUrl = "https://d2lswn7b0fl4u2.cloudfront.net/photos/pg-mushroom-swiss-burger-1612796532.jpg" });

            modelBuilder.Entity<Order>().HasData(
                new Order { Id = 1, FullName = "John Doe", Address = "123 Main St", IsDelivered = false, LocationId = 1 },
                new Order { Id = 2, FullName = "Jane Smith", Address = "789 Oak St", IsDelivered = true, LocationId = 2 },
                new Order { Id = 3, FullName = "Alice Johnson", Address = "456 Pine St", IsDelivered = true, LocationId = 3 },
                new Order { Id = 4, FullName = "Michael Davis", Address = "987 Walnut Ln", IsDelivered = false, LocationId = 4 },
                new Order { Id = 5, FullName = "Sarah Wilson", Address = "321 Elm St", IsDelivered = false, LocationId = 5 });

            modelBuilder.Entity<Location>().HasData(
                new Location { Id = 1, Name = "Downtown", Address = "456 Main St", OpensAt = TimeSpan.FromHours(10), ClosesAt = TimeSpan.FromHours(22) },
                new Location { Id = 2, Name = "Midtown", Address = "789 Elm St", OpensAt = TimeSpan.FromHours(9), ClosesAt = TimeSpan.FromHours(20) },
                new Location { Id = 3, Name = "Uptown", Address = "123 Oak St", OpensAt = TimeSpan.FromHours(11), ClosesAt = TimeSpan.FromHours(21) },
                new Location { Id = 4, Name = "Westside", Address = "987 Pine St", OpensAt = TimeSpan.FromHours(10), ClosesAt = TimeSpan.FromHours(22) },
                new Location { Id = 5, Name = "Eastside", Address = "321 Walnut Ln", OpensAt = TimeSpan.FromHours(9), ClosesAt = TimeSpan.FromHours(20) });

            modelBuilder.Entity<BurgerOrder>().HasData(
                new BurgerOrder { Id = 1, OrderId = 1, BurgerId = 1 },
                new BurgerOrder { Id = 2, OrderId = 1, BurgerId = 2 },
                new BurgerOrder { Id = 3, OrderId = 2, BurgerId = 3 },
                new BurgerOrder { Id = 4, OrderId = 2, BurgerId = 4 },
                new BurgerOrder { Id = 5, OrderId = 3, BurgerId = 1 },
                new BurgerOrder { Id = 6, OrderId = 3, BurgerId = 5 },
                new BurgerOrder { Id = 7, OrderId = 4, BurgerId = 2 },
                new BurgerOrder { Id = 8, OrderId = 5, BurgerId = 3 });
        }
    }
}
