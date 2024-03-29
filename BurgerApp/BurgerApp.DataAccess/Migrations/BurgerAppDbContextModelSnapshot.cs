﻿// <auto-generated />
using System;
using BurgerApp.DataAccess.DataContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BurgerApp.DataAccess.Migrations
{
    [DbContext(typeof(BurgerAppDbContext))]
    partial class BurgerAppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BurgerApp.Domain.Models.Burger", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("HasFries")
                        .HasColumnType("bit");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsVegan")
                        .HasColumnType("bit");

                    b.Property<bool>("IsVegetarian")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Burgers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            HasFries = true,
                            ImageUrl = "https://rhubarbandcod.com/wp-content/uploads/2022/06/The-Classic-Cheeseburger-1-500x500.jpg",
                            IsVegan = false,
                            IsVegetarian = false,
                            Name = "Classic Cheeseburger",
                            Price = 180.0
                        },
                        new
                        {
                            Id = 2,
                            HasFries = true,
                            ImageUrl = "https://www.kitchensanctuary.com/wp-content/uploads/2019/05/Cheesy-Veggie-Burger-Square-1200-500x500.jpg",
                            IsVegan = false,
                            IsVegetarian = true,
                            Name = "Veggie Burger",
                            Price = 200.0
                        },
                        new
                        {
                            Id = 3,
                            HasFries = true,
                            ImageUrl = "https://www.vegangrocerystore.com.au/cdn/shop/products/beyondburger_d0846b9c-a82c-4eaa-9f19-ee0be12d6bbc_800x.jpg?v=1624689743",
                            IsVegan = true,
                            IsVegetarian = false,
                            Name = "Beyond Burger",
                            Price = 220.0
                        },
                        new
                        {
                            Id = 4,
                            HasFries = true,
                            ImageUrl = "https://simply-delicious-food.com/wp-content/uploads/2015/07/Bacon-and-cheese-burgers-3.jpg",
                            IsVegan = false,
                            IsVegetarian = false,
                            Name = "Bacon Cheeseburger",
                            Price = 240.0
                        },
                        new
                        {
                            Id = 5,
                            HasFries = false,
                            ImageUrl = "https://d2lswn7b0fl4u2.cloudfront.net/photos/pg-mushroom-swiss-burger-1612796532.jpg",
                            IsVegan = false,
                            IsVegetarian = false,
                            Name = "Mushroom Swiss Burger",
                            Price = 260.0
                        });
                });

            modelBuilder.Entity("BurgerApp.Domain.Models.BurgerOrder", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BurgerId")
                        .HasColumnType("int");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BurgerId");

                    b.HasIndex("OrderId");

                    b.ToTable("BurgerOrder");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BurgerId = 1,
                            OrderId = 1
                        },
                        new
                        {
                            Id = 2,
                            BurgerId = 2,
                            OrderId = 1
                        },
                        new
                        {
                            Id = 3,
                            BurgerId = 3,
                            OrderId = 2
                        },
                        new
                        {
                            Id = 4,
                            BurgerId = 4,
                            OrderId = 2
                        },
                        new
                        {
                            Id = 5,
                            BurgerId = 1,
                            OrderId = 3
                        },
                        new
                        {
                            Id = 6,
                            BurgerId = 5,
                            OrderId = 3
                        },
                        new
                        {
                            Id = 7,
                            BurgerId = 2,
                            OrderId = 4
                        },
                        new
                        {
                            Id = 8,
                            BurgerId = 3,
                            OrderId = 5
                        });
                });

            modelBuilder.Entity("BurgerApp.Domain.Models.Location", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<TimeSpan>("ClosesAt")
                        .HasColumnType("time");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<TimeSpan>("OpensAt")
                        .HasColumnType("time");

                    b.HasKey("Id");

                    b.ToTable("Locations");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "456 Main St",
                            ClosesAt = new TimeSpan(0, 22, 0, 0, 0),
                            Name = "Downtown",
                            OpensAt = new TimeSpan(0, 10, 0, 0, 0)
                        },
                        new
                        {
                            Id = 2,
                            Address = "789 Elm St",
                            ClosesAt = new TimeSpan(0, 20, 0, 0, 0),
                            Name = "Midtown",
                            OpensAt = new TimeSpan(0, 9, 0, 0, 0)
                        },
                        new
                        {
                            Id = 3,
                            Address = "123 Oak St",
                            ClosesAt = new TimeSpan(0, 21, 0, 0, 0),
                            Name = "Uptown",
                            OpensAt = new TimeSpan(0, 11, 0, 0, 0)
                        },
                        new
                        {
                            Id = 4,
                            Address = "987 Pine St",
                            ClosesAt = new TimeSpan(0, 22, 0, 0, 0),
                            Name = "Westside",
                            OpensAt = new TimeSpan(0, 10, 0, 0, 0)
                        },
                        new
                        {
                            Id = 5,
                            Address = "321 Walnut Ln",
                            ClosesAt = new TimeSpan(0, 20, 0, 0, 0),
                            Name = "Eastside",
                            OpensAt = new TimeSpan(0, 9, 0, 0, 0)
                        });
                });

            modelBuilder.Entity("BurgerApp.Domain.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDelivered")
                        .HasColumnType("bit");

                    b.Property<int>("LocationId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("LocationId");

                    b.ToTable("Orders");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "123 Main St",
                            FullName = "John Doe",
                            IsDelivered = false,
                            LocationId = 1
                        },
                        new
                        {
                            Id = 2,
                            Address = "789 Oak St",
                            FullName = "Jane Smith",
                            IsDelivered = true,
                            LocationId = 2
                        },
                        new
                        {
                            Id = 3,
                            Address = "456 Pine St",
                            FullName = "Alice Johnson",
                            IsDelivered = true,
                            LocationId = 3
                        },
                        new
                        {
                            Id = 4,
                            Address = "987 Walnut Ln",
                            FullName = "Michael Davis",
                            IsDelivered = false,
                            LocationId = 4
                        },
                        new
                        {
                            Id = 5,
                            Address = "321 Elm St",
                            FullName = "Sarah Wilson",
                            IsDelivered = false,
                            LocationId = 5
                        });
                });

            modelBuilder.Entity("BurgerApp.Domain.Models.BurgerOrder", b =>
                {
                    b.HasOne("BurgerApp.Domain.Models.Burger", "Burger")
                        .WithMany("BurgerOrders")
                        .HasForeignKey("BurgerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BurgerApp.Domain.Models.Order", "Order")
                        .WithMany("BurgerOrders")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Burger");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("BurgerApp.Domain.Models.Order", b =>
                {
                    b.HasOne("BurgerApp.Domain.Models.Location", "Location")
                        .WithMany("Orders")
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Location");
                });

            modelBuilder.Entity("BurgerApp.Domain.Models.Burger", b =>
                {
                    b.Navigation("BurgerOrders");
                });

            modelBuilder.Entity("BurgerApp.Domain.Models.Location", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("BurgerApp.Domain.Models.Order", b =>
                {
                    b.Navigation("BurgerOrders");
                });
#pragma warning restore 612, 618
        }
    }
}
