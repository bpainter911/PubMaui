﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PubMaui.Api.Data;

#nullable disable

namespace PubMaui.Api.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20240220214213_ChangeUserInfo")]
    partial class ChangeUserInfo
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("PubMaui.Api.Data.Entities.Menu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasMaxLength(180)
                        .HasColumnType("nvarchar(180)");

                    b.Property<string>("MName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int?>("MenuCategoryCategoryId")
                        .HasColumnType("int");

                    b.Property<double>("RetailPrice")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("MenuCategoryCategoryId");

                    b.ToTable("Menu");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Category = "Starter",
                            CategoryId = 1,
                            Description = "",
                            Image = "https://github.com/bpainter911/publib/blob/main/ForMaui/mozarella.png",
                            MName = "Mozzarella Sticks",
                            RetailPrice = 13.0
                        },
                        new
                        {
                            Id = 2,
                            Category = "Starter",
                            CategoryId = 1,
                            Description = "",
                            Image = "https://github.com/bpainter911/publib/blob/main/ForMaui/frenchfriesontable.png",
                            MName = "Basket of Fries",
                            RetailPrice = 9.0
                        },
                        new
                        {
                            Id = 3,
                            Category = "Starter",
                            CategoryId = 1,
                            Description = "",
                            Image = "https://github.com/bpainter911/publib/blob/main/ForMaui/picklespears.png",
                            MName = "Dill Pickle Spears",
                            RetailPrice = 10.0
                        },
                        new
                        {
                            Id = 4,
                            Category = "Starter",
                            CategoryId = 1,
                            Description = "",
                            Image = "https://github.com/bpainter911/publib/blob/main/ForMaui/latticefries.png",
                            MName = "Loaded Lattice Fries",
                            RetailPrice = 15.0
                        },
                        new
                        {
                            Id = 5,
                            Category = "Starter",
                            CategoryId = 1,
                            Description = "",
                            Image = "https://github.com/bpainter911/publib/blob/main/ForMaui/onionrings.png",
                            MName = "Buttermilk Onion Rings",
                            RetailPrice = 10.0
                        },
                        new
                        {
                            Id = 6,
                            Category = "Starter",
                            CategoryId = 1,
                            Description = "",
                            Image = "https://github.com/bpainter911/publib/blob/main/ForMaui/montrealpoutine.png",
                            MName = "Montreal Style Poutine",
                            RetailPrice = 12.0
                        },
                        new
                        {
                            Id = 7,
                            Category = "Starter",
                            CategoryId = 1,
                            Description = "",
                            Image = "https://github.com/bpainter911/publib/blob/main/ForMaui/sweetpotato.png",
                            MName = "Sweet Potato Fries",
                            RetailPrice = 10.0
                        },
                        new
                        {
                            Id = 8,
                            Category = "Starter",
                            CategoryId = 1,
                            Description = "",
                            Image = "https://github.com/bpainter911/publib/blob/main/ForMaui/souponsky.png",
                            MName = "Soup of the Day",
                            RetailPrice = 8.0
                        },
                        new
                        {
                            Id = 9,
                            Category = "Starter",
                            CategoryId = 1,
                            Description = "",
                            Image = "https://github.com/bpainter911/publib/blob/main/ForMaui/onionsoupontableecu.png",
                            MName = "French Onion Soup",
                            RetailPrice = 9.0
                        },
                        new
                        {
                            Id = 10,
                            Category = "Salads",
                            CategoryId = 2,
                            Description = "",
                            Image = "https://github.com/bpainter911/publib/blob/main/ForMaui/saladmandarin.png",
                            MName = "Mandarin Salad",
                            RetailPrice = 15.0
                        },
                        new
                        {
                            Id = 11,
                            Category = "Salads",
                            CategoryId = 2,
                            Description = "",
                            Image = "https://github.com/bpainter911/publib/blob/main/ForMaui/cobbsaladontable.png",
                            MName = "Cobb Salad",
                            RetailPrice = 17.0
                        },
                        new
                        {
                            Id = 12,
                            Category = "Salads",
                            CategoryId = 2,
                            Description = "",
                            Image = "https://github.com/bpainter911/publib/blob/main/ForMaui/greeklarge.png",
                            MName = "Greek Salad",
                            RetailPrice = 9.0
                        },
                        new
                        {
                            Id = 13,
                            Category = "Salads",
                            CategoryId = 2,
                            Description = "",
                            Image = "https://github.com/bpainter911/publib/blob/main/ForMaui/caesarsalad.png",
                            MName = "Classic Caesar Salad",
                            RetailPrice = 9.0
                        },
                        new
                        {
                            Id = 14,
                            Category = "Salads",
                            CategoryId = 2,
                            Description = "",
                            Image = "https://github.com/bpainter911/publib/blob/main/ForMaui/saladhouse.png",
                            MName = "Cookstown House Salad",
                            RetailPrice = 13.0
                        },
                        new
                        {
                            Id = 15,
                            Category = "Wings",
                            CategoryId = 3,
                            Description = "",
                            Image = "https://github.com/bpainter911/publib/blob/main/ForMaui/wingsmedium.png",
                            MName = "Wings - Single Order One Pound",
                            RetailPrice = 19.0
                        },
                        new
                        {
                            Id = 16,
                            Category = "Wings",
                            CategoryId = 3,
                            Description = "",
                            Image = "https://github.com/bpainter911/publib/blob/main/ForMaui/wingsmedium.png",
                            MName = "Wings - Double Order Two Pounds",
                            RetailPrice = 37.0
                        },
                        new
                        {
                            Id = 17,
                            Category = "Wings",
                            CategoryId = 3,
                            Description = "",
                            Image = "https://github.com/bpainter911/publib/blob/main/ForMaui/wingsmedium.png",
                            MName = "Wings - Party Order Three Pounds",
                            RetailPrice = 50.0
                        },
                        new
                        {
                            Id = 18,
                            Category = "Pub Favourites",
                            CategoryId = 4,
                            Description = "",
                            Image = "https://github.com/bpainter911/publib/blob/main/ForMaui/chickenfingersbooth.png",
                            MName = "Chicken Fingers and Fries",
                            RetailPrice = 16.0
                        },
                        new
                        {
                            Id = 19,
                            Category = "Pub Favourites",
                            CategoryId = 4,
                            Description = "",
                            Image = "https://github.com/bpainter911/publib/blob/main/ForMaui/perogi.png",
                            MName = "Ava's Perogies",
                            RetailPrice = 16.0
                        },
                        new
                        {
                            Id = 20,
                            Category = "Pub Favourites",
                            CategoryId = 4,
                            Description = "",
                            Image = "https://github.com/bpainter911/publib/blob/main/ForMaui/fishontablecu.png",
                            MName = "Beer Battered Fish & Chips",
                            RetailPrice = 21.0
                        },
                        new
                        {
                            Id = 21,
                            Category = "Pub Favourites",
                            CategoryId = 4,
                            Description = "",
                            Image = "https://github.com/bpainter911/publib/blob/main/ForMaui/chickenfingersbooth.png",
                            MName = "Chicken Fingers and Fries Buffalo Style",
                            RetailPrice = 17.0
                        },
                        new
                        {
                            Id = 22,
                            Category = "Pub Favourites",
                            CategoryId = 4,
                            Description = "",
                            Image = "https://github.com/bpainter911/publib/blob/main/ForMaui/quesadilla.png",
                            MName = "Quesadilla",
                            RetailPrice = 10.0
                        },
                        new
                        {
                            Id = 23,
                            Category = "Pub Favourites",
                            CategoryId = 4,
                            Description = "",
                            Image = "",
                            MName = "Nachos",
                            RetailPrice = 20.0
                        },
                        new
                        {
                            Id = 24,
                            Category = "Pub Favourites",
                            CategoryId = 4,
                            Description = "",
                            Image = "https://github.com/bpainter911/publib/blob/main/ForMaui/chickentet.png",
                            MName = "Chicken Tetrazzini",
                            RetailPrice = 19.0
                        },
                        new
                        {
                            Id = 25,
                            Category = "Pub Favourites",
                            CategoryId = 4,
                            Description = "",
                            Image = "https://github.com/bpainter911/publib/blob/main/ForMaui/bangersmash.png",
                            MName = "Bangers and Mash",
                            RetailPrice = 15.0
                        },
                        new
                        {
                            Id = 26,
                            Category = "Pub Favourites",
                            CategoryId = 4,
                            Description = "",
                            Image = "https://github.com/bpainter911/publib/blob/main/ForMaui/shepherdspie.png",
                            MName = "Shepherds Pie",
                            RetailPrice = 16.0
                        },
                        new
                        {
                            Id = 27,
                            Category = "Pub Favourites",
                            CategoryId = 4,
                            Description = "",
                            Image = "https://github.com/bpainter911/publib/blob/main/ForMaui/liveronion.png",
                            MName = "Liver and Onions",
                            RetailPrice = 18.0
                        },
                        new
                        {
                            Id = 28,
                            Category = "Pub Favourites",
                            CategoryId = 4,
                            Description = "",
                            Image = "https://github.com/bpainter911/publib/blob/main/ForMaui/chili.png",
                            MName = "Texas Chili",
                            RetailPrice = 15.0
                        },
                        new
                        {
                            Id = 29,
                            Category = "Pub Favourites",
                            CategoryId = 4,
                            Description = "",
                            Image = "",
                            MName = "Mushroom Garlic Meatloaf",
                            RetailPrice = 18.0
                        },
                        new
                        {
                            Id = 30,
                            Category = "Sandwiches and Burgers",
                            CategoryId = 5,
                            Description = "",
                            Image = "https://github.com/bpainter911/publib/blob/main/ForMaui/buffalochickenwrap.png",
                            MName = "Chicken Wrap",
                            RetailPrice = 18.0
                        },
                        new
                        {
                            Id = 31,
                            Category = "Sandwiches and Burgers",
                            CategoryId = 5,
                            Description = "",
                            Image = "https://github.com/bpainter911/publib/blob/main/ForMaui/burgerg.png",
                            MName = "Yukon Gold Burger",
                            RetailPrice = 18.0
                        },
                        new
                        {
                            Id = 32,
                            Category = "Sandwiches and Burgers",
                            CategoryId = 5,
                            Description = "",
                            Image = "https://github.com/bpainter911/publib/blob/main/ForMaui/burgerclassic.png",
                            MName = "Cookstown Classic Burger",
                            RetailPrice = 17.0
                        },
                        new
                        {
                            Id = 33,
                            Category = "Sandwiches and Burgers",
                            CategoryId = 5,
                            Description = "",
                            Image = "",
                            MName = "Classic Clubhouse",
                            RetailPrice = 18.0
                        },
                        new
                        {
                            Id = 34,
                            Category = "Sandwiches and Burgers",
                            CategoryId = 5,
                            Description = "",
                            Image = "https://github.com/bpainter911/publib/blob/main/ForMaui/burgerg.png",
                            MName = "The Cookstown 'BIG' Burger",
                            RetailPrice = 22.0
                        },
                        new
                        {
                            Id = 35,
                            Category = "Sandwiches and Burgers",
                            CategoryId = 5,
                            Description = "",
                            Image = "https://github.com/bpainter911/publib/blob/main/ForMaui/beefdip.png",
                            MName = "Loaded Beef Dip",
                            RetailPrice = 20.0
                        },
                        new
                        {
                            Id = 36,
                            Category = "Sandwiches and Burgers",
                            CategoryId = 5,
                            Description = "",
                            Image = "https://github.com/bpainter911/publib/blob/main/ForMaui/burgerms.png",
                            MName = "Mushroom Swiss Burger",
                            RetailPrice = 19.5
                        },
                        new
                        {
                            Id = 37,
                            Category = "Sandwiches and Burgers",
                            CategoryId = 5,
                            Description = "",
                            Image = "https://github.com/bpainter911/publib/blob/main/ForMaui/burgerblue.png",
                            MName = "The Big Blue Burger",
                            RetailPrice = 19.5
                        },
                        new
                        {
                            Id = 38,
                            Category = "Sandwiches and Burgers",
                            CategoryId = 5,
                            Description = "",
                            Image = "https://github.com/bpainter911/publib/blob/main/ForMaui/pulledpork.png",
                            MName = "Pulled Pork on a Bun",
                            RetailPrice = 17.0
                        },
                        new
                        {
                            Id = 39,
                            Category = "Famous Flatbreads",
                            CategoryId = 6,
                            Description = "",
                            Image = "https://github.com/bpainter911/publib/blob/main/ForMaui/mediterrflat.png",
                            MName = "Loaded Flatbread",
                            RetailPrice = 15.0
                        },
                        new
                        {
                            Id = 40,
                            Category = "Famous Flatbreads",
                            CategoryId = 6,
                            Description = "",
                            Image = "https://github.com/bpainter911/publib/blob/main/ForMaui/flatbreadchick.png",
                            MName = "Chicken & Goat Cheese Flatbread",
                            RetailPrice = 18.0
                        },
                        new
                        {
                            Id = 41,
                            Category = "Famous Flatbreads",
                            CategoryId = 6,
                            Description = "",
                            Image = "https://github.com/bpainter911/publib/blob/main/ForMaui/bruschetta.png",
                            MName = "Bruschetta",
                            RetailPrice = 12.0
                        },
                        new
                        {
                            Id = 42,
                            Category = "Famous Flatbreads",
                            CategoryId = 6,
                            Description = "",
                            Image = "https://github.com/bpainter911/publib/blob/main/ForMaui/cheesygarlicontable.png",
                            MName = "Cheesy Garlic Flatbread",
                            RetailPrice = 10.0
                        },
                        new
                        {
                            Id = 43,
                            Category = "Famous Flatbreads",
                            CategoryId = 6,
                            Description = "",
                            Image = "https://github.com/bpainter911/publib/blob/main/ForMaui/cheesygarlicwbacon.png",
                            MName = "Cheesy Garlic Flatbread With Bacon",
                            RetailPrice = 12.0
                        },
                        new
                        {
                            Id = 44,
                            Category = "Cookstown Pub Desserts",
                            CategoryId = 7,
                            Description = "",
                            Image = "https://github.com/bpainter911/publib/blob/main/ForMaui/toffee.png",
                            MName = "Sticky Toffee Pudding Cake",
                            RetailPrice = 7.0
                        },
                        new
                        {
                            Id = 45,
                            Category = "Cookstown Pub Desserts",
                            CategoryId = 7,
                            Description = "",
                            Image = "https://github.com/bpainter911/publib/blob/main/ForMaui/oreos.png",
                            MName = "Deep Fried Oreos",
                            RetailPrice = 8.0
                        },
                        new
                        {
                            Id = 46,
                            Category = "Cookstown Pub Desserts",
                            CategoryId = 7,
                            Description = "",
                            Image = "https://github.com/bpainter911/publib/blob/main/ForMaui/brownie.png",
                            MName = "Brownie Bliss",
                            RetailPrice = 8.0
                        });
                });

            modelBuilder.Entity("PubMaui.Api.Data.Entities.MenuCategory", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"));

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CategoryDiscription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("MenuCategories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            Category = "Starters",
                            CategoryDiscription = ""
                        },
                        new
                        {
                            CategoryId = 2,
                            Category = "Salads",
                            CategoryDiscription = ""
                        },
                        new
                        {
                            CategoryId = 3,
                            Category = "Wings",
                            CategoryDiscription = ""
                        },
                        new
                        {
                            CategoryId = 4,
                            Category = "Pub Favourites",
                            CategoryDiscription = ""
                        },
                        new
                        {
                            CategoryId = 5,
                            Category = "Sandwiches and Burgers",
                            CategoryDiscription = ""
                        },
                        new
                        {
                            CategoryId = 6,
                            Category = "Famous Flatbreads",
                            CategoryDiscription = ""
                        },
                        new
                        {
                            CategoryId = 7,
                            Category = "Cookstown Pub Desserts",
                            CategoryDiscription = ""
                        });
                });

            modelBuilder.Entity("PubMaui.Api.Data.Entities.MenuOptions", b =>
                {
                    b.Property<int>("MenuId")
                        .HasColumnType("int");

                    b.Property<string>("ItemOption")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<double>("ItemOptionPrice")
                        .HasColumnType("float");

                    b.HasKey("MenuId", "ItemOption", "ItemOptionPrice");

                    b.ToTable("MenuOptions");

                    b.HasData(
                        new
                        {
                            MenuId = 2,
                            ItemOption = "Add Gravy",
                            ItemOptionPrice = 2.0
                        },
                        new
                        {
                            MenuId = 12,
                            ItemOption = "Make it a Large",
                            ItemOptionPrice = 6.0
                        },
                        new
                        {
                            MenuId = 13,
                            ItemOption = "Make it a Large",
                            ItemOptionPrice = 6.0
                        },
                        new
                        {
                            MenuId = 15,
                            ItemOption = "Samll Baskit of Fries",
                            ItemOptionPrice = 6.0
                        },
                        new
                        {
                            MenuId = 15,
                            ItemOption = "Add Gravy",
                            ItemOptionPrice = 2.0
                        },
                        new
                        {
                            MenuId = 16,
                            ItemOption = "Samll Baskit of Fries",
                            ItemOptionPrice = 6.0
                        },
                        new
                        {
                            MenuId = 16,
                            ItemOption = "Add Gravy",
                            ItemOptionPrice = 2.0
                        },
                        new
                        {
                            MenuId = 17,
                            ItemOption = "Samll Baskit of Fries",
                            ItemOptionPrice = 6.0
                        },
                        new
                        {
                            MenuId = 17,
                            ItemOption = "Add Gravy",
                            ItemOptionPrice = 2.0
                        },
                        new
                        {
                            MenuId = 18,
                            ItemOption = "Add Gravy",
                            ItemOptionPrice = 2.0
                        },
                        new
                        {
                            MenuId = 20,
                            ItemOption = "Add Gravy",
                            ItemOptionPrice = 2.0
                        },
                        new
                        {
                            MenuId = 21,
                            ItemOption = "Add Gravy",
                            ItemOptionPrice = 2.0
                        },
                        new
                        {
                            MenuId = 30,
                            ItemOption = "Add Gravy",
                            ItemOptionPrice = 2.0
                        },
                        new
                        {
                            MenuId = 31,
                            ItemOption = "Add Gravy",
                            ItemOptionPrice = 2.0
                        },
                        new
                        {
                            MenuId = 32,
                            ItemOption = "Add Gravy",
                            ItemOptionPrice = 2.0
                        },
                        new
                        {
                            MenuId = 33,
                            ItemOption = "Add Gravy",
                            ItemOptionPrice = 2.0
                        },
                        new
                        {
                            MenuId = 34,
                            ItemOption = "Add Gravy",
                            ItemOptionPrice = 2.0
                        },
                        new
                        {
                            MenuId = 35,
                            ItemOption = "Add Gravy",
                            ItemOptionPrice = 2.0
                        },
                        new
                        {
                            MenuId = 36,
                            ItemOption = "Add Gravy",
                            ItemOptionPrice = 2.0
                        },
                        new
                        {
                            MenuId = 37,
                            ItemOption = "Add Gravy",
                            ItemOptionPrice = 2.0
                        },
                        new
                        {
                            MenuId = 38,
                            ItemOption = "Add Gravy",
                            ItemOptionPrice = 2.0
                        });
                });

            modelBuilder.Entity("PubMaui.Api.Data.Entities.Order", b =>
                {
                    b.Property<long>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("OrderId"));

                    b.Property<Guid>("CustomerAddress")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CustomerCityTown")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CustomerEmail")
                        .HasMaxLength(100)
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CustomerFullName")
                        .HasMaxLength(90)
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CustomerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CustomerPhNumber")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("OrderAt")
                        .HasColumnType("datetime2");

                    b.Property<double>("OrderSum")
                        .HasColumnType("float");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<double>("Tax")
                        .HasColumnType("float");

                    b.HasKey("OrderId");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("PubMaui.Api.Data.Entities.OrderItems", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("ItemOption")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<double>("ItemOptionPrice")
                        .HasColumnType("float");

                    b.Property<int>("MId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(90)
                        .HasColumnType("nvarchar(90)");

                    b.Property<long>("OrderId")
                        .HasColumnType("bigint");

                    b.Property<double>("OrderSum")
                        .HasColumnType("float");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<double>("Quantity")
                        .HasColumnType("float");

                    b.Property<double>("Tax")
                        .HasColumnType("float");

                    b.Property<double>("TotalOrderSum")
                        .HasColumnType("float");

                    b.Property<double>("TotalPrice")
                        .HasColumnType("float");

                    b.Property<double>("TotalTax")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.ToTable("OrderItems");
                });

            modelBuilder.Entity("PubMaui.Api.Data.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CityTown")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(90)
                        .HasColumnType("nvarchar(90)");

                    b.Property<string>("Hash")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostalCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Salt")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("PubMaui.Api.Data.Entities.Menu", b =>
                {
                    b.HasOne("PubMaui.Api.Data.Entities.MenuCategory", null)
                        .WithMany("Menu")
                        .HasForeignKey("MenuCategoryCategoryId");
                });

            modelBuilder.Entity("PubMaui.Api.Data.Entities.MenuOptions", b =>
                {
                    b.HasOne("PubMaui.Api.Data.Entities.Menu", "menu")
                        .WithMany("Options")
                        .HasForeignKey("MenuId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("menu");
                });

            modelBuilder.Entity("PubMaui.Api.Data.Entities.OrderItems", b =>
                {
                    b.HasOne("PubMaui.Api.Data.Entities.Order", "Order")
                        .WithMany("Items")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");
                });

            modelBuilder.Entity("PubMaui.Api.Data.Entities.Menu", b =>
                {
                    b.Navigation("Options");
                });

            modelBuilder.Entity("PubMaui.Api.Data.Entities.MenuCategory", b =>
                {
                    b.Navigation("Menu");
                });

            modelBuilder.Entity("PubMaui.Api.Data.Entities.Order", b =>
                {
                    b.Navigation("Items");
                });
#pragma warning restore 612, 618
        }
    }
}
