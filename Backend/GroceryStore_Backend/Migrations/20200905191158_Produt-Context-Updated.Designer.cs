﻿// <auto-generated />
using System;
using GroceryStore_Backend.Repository.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GroceryStore_Backend.Migrations
{
    [DbContext(typeof(GroceryStoreDbContext))]
    [Migration("20200905191158_Produt-Context-Updated")]
    partial class ProdutContextUpdated
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GroceryStore_Backend.Models.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Address")
                        .HasColumnType("int");

                    b.Property<string>("AreaName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HouseName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PinCode")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Address");

                    b.ToTable("Address");
                });

            modelBuilder.Entity("GroceryStore_Backend.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("GroceryStore_Backend.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Category")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Descrption")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Price")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Product");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Category = "Vegetables",
                            Descrption = "amla",
                            ImagePath = "../../src/assets/products/amla.jpg",
                            Price = "0.50",
                            ProductName = "amla"
                        },
                        new
                        {
                            Id = 2,
                            Category = "Vegetables",
                            Descrption = "arbi(sham_root)",
                            ImagePath = "../../src/assets/products/arbi(sham_root).jpg",
                            Price = "0.50",
                            ProductName = "arbi(sham_root)"
                        },
                        new
                        {
                            Id = 3,
                            Category = "Vegetables",
                            Descrption = "baby_corn",
                            ImagePath = "../../src/assets/products/baby_corn.jpg",
                            Price = "0.50",
                            ProductName = "baby_corn"
                        },
                        new
                        {
                            Id = 4,
                            Category = "Vegetables",
                            Descrption = "baby_jackfruit",
                            ImagePath = "../../src/assets/products/baby_jackfruit.jpg",
                            Price = "0.50",
                            ProductName = "baby_jackfruit"
                        },
                        new
                        {
                            Id = 5,
                            Category = "Vegetables",
                            Descrption = "banana_flower",
                            ImagePath = "../../src/assets/products/banana_flower.jpg",
                            Price = "0.50",
                            ProductName = "banana_flower"
                        },
                        new
                        {
                            Id = 6,
                            Category = "Vegetables",
                            Descrption = "banana_stem",
                            ImagePath = "../../src/assets/products/banana_stem.jpg",
                            Price = "0.50",
                            ProductName = "banana_stem"
                        },
                        new
                        {
                            Id = 7,
                            Category = "Vegetables",
                            Descrption = "beans_long",
                            ImagePath = "../../src/assets/products/beans_long.jpg",
                            Price = "0.50",
                            ProductName = "beans_long"
                        },
                        new
                        {
                            Id = 8,
                            Category = "Vegetables",
                            Descrption = "beans_natti",
                            ImagePath = "../../src/assets/products/beans_natti.jpg",
                            Price = "0.50",
                            ProductName = "beans_natti"
                        },
                        new
                        {
                            Id = 9,
                            Category = "Vegetables",
                            Descrption = "beans_ring",
                            ImagePath = "../../src/assets/products/beans_ring.jpg",
                            Price = "0.50",
                            ProductName = "beans_ring"
                        },
                        new
                        {
                            Id = 10,
                            Category = "Vegetables",
                            Descrption = "beetroot",
                            ImagePath = "../../src/assets/products/beetroot.jpg",
                            Price = "0.50",
                            ProductName = "beetroot"
                        },
                        new
                        {
                            Id = 11,
                            Category = "Vegetables",
                            Descrption = "bitter_gourd",
                            ImagePath = "../../src/assets/products/bitter_gourd.jpg",
                            Price = "0.50",
                            ProductName = "bitter_gourd"
                        },
                        new
                        {
                            Id = 12,
                            Category = "Vegetables",
                            Descrption = "bottle_brinjal",
                            ImagePath = "../../src/assets/products/bottle_brinjal.jpg",
                            Price = "0.50",
                            ProductName = "bottle_brinjal"
                        },
                        new
                        {
                            Id = 13,
                            Category = "Vegetables",
                            Descrption = "bottle_gourd",
                            ImagePath = "../../src/assets/products/bottle_gourd.jpg",
                            Price = "0.50",
                            ProductName = "bottle_gourd"
                        },
                        new
                        {
                            Id = 14,
                            Category = "Vegetables",
                            Descrption = "brinjal_green",
                            ImagePath = "../../src/assets/products/brinjal_green.jpg",
                            Price = "0.50",
                            ProductName = "brinjal_green"
                        },
                        new
                        {
                            Id = 15,
                            Category = "Vegetables",
                            Descrption = "brinjal_round",
                            ImagePath = "../../src/assets/products/brinjal_round.jpg",
                            Price = "0.50",
                            ProductName = "brinjal_round"
                        },
                        new
                        {
                            Id = 16,
                            Category = "Vegetables",
                            Descrption = "broccoli",
                            ImagePath = "../../src/assets/products/broccoli.jpg",
                            Price = "0.50",
                            ProductName = "broccoli"
                        },
                        new
                        {
                            Id = 17,
                            Category = "Vegetables",
                            Descrption = "cabbage",
                            ImagePath = "../../src/assets/products/cabbage.jpg",
                            Price = "0.50",
                            ProductName = "cabbage"
                        },
                        new
                        {
                            Id = 18,
                            Category = "Vegetables",
                            Descrption = "capsicum_green",
                            ImagePath = "../../src/assets/products/capsicum_green.jpg",
                            Price = "0.50",
                            ProductName = "capsicum_green"
                        },
                        new
                        {
                            Id = 19,
                            Category = "Vegetables",
                            Descrption = "capsicum_red",
                            ImagePath = "../../src/assets/products/capsicum_red.jpg",
                            Price = "0.50",
                            ProductName = "capsicum_red"
                        },
                        new
                        {
                            Id = 20,
                            Category = "Vegetables",
                            Descrption = "capsicum_yellow",
                            ImagePath = "../../src/assets/products/capsicum_yellow.jpg",
                            Price = "0.50",
                            ProductName = "capsicum_yellow"
                        },
                        new
                        {
                            Id = 21,
                            Category = "Vegetables",
                            Descrption = "carrot_ooty",
                            ImagePath = "../../src/assets/products/carrot_ooty.jpg",
                            Price = "0.50",
                            ProductName = "carrot_ooty"
                        },
                        new
                        {
                            Id = 22,
                            Category = "Vegetables",
                            Descrption = "cauli_flower",
                            ImagePath = "../../src/assets/products/cauli_flower.jpg",
                            Price = "0.50",
                            ProductName = "cauli_flower"
                        },
                        new
                        {
                            Id = 23,
                            Category = "Vegetables",
                            Descrption = "chilli_green",
                            ImagePath = "../../src/assets/products/chilli_green.jpg",
                            Price = "0.50",
                            ProductName = "chilli_green"
                        },
                        new
                        {
                            Id = 24,
                            Category = "Vegetables",
                            Descrption = "chow_chow",
                            ImagePath = "../../src/assets/products/chow_chow.jpg",
                            Price = "0.50",
                            ProductName = "chow_chow"
                        },
                        new
                        {
                            Id = 25,
                            Category = "Vegetables",
                            Descrption = "cluster_beans",
                            ImagePath = "../../src/assets/products/cluster_beans.jpg",
                            Price = "0.50",
                            ProductName = "cluster_beans"
                        },
                        new
                        {
                            Id = 26,
                            Category = "Vegetables",
                            Descrption = "coconut",
                            ImagePath = "../../src/assets/products/coconut.jpg",
                            Price = "0.50",
                            ProductName = "coconut"
                        },
                        new
                        {
                            Id = 27,
                            Category = "Vegetables",
                            Descrption = "flat_beans",
                            ImagePath = "../../src/assets/products/flat_beans.jpg",
                            Price = "0.50",
                            ProductName = "flat_beans"
                        });
                });

            modelBuilder.Entity("GroceryStore_Backend.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("GroceryStore_Backend.Models.Address", b =>
                {
                    b.HasOne("GroceryStore_Backend.Models.User", null)
                        .WithMany("Address")
                        .HasForeignKey("Address");
                });
#pragma warning restore 612, 618
        }
    }
}
