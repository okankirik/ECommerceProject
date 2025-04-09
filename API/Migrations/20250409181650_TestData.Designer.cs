﻿// <auto-generated />
using API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace API.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20250409181650_TestData")]
    partial class TestData
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.0");

            modelBuilder.Entity("API.Entity.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsActive")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.Property<int>("Stock")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Telefon Açıklaması",
                            ImageUrl = "1.jpg",
                            IsActive = true,
                            Name = "Iphone 15",
                            Price = 70000m,
                            Stock = 100
                        },
                        new
                        {
                            Id = 2,
                            Description = "Telefon Açıklaması",
                            ImageUrl = "2.jpg",
                            IsActive = true,
                            Name = "Iphone 16",
                            Price = 80000m,
                            Stock = 100
                        },
                        new
                        {
                            Id = 3,
                            Description = "Telefon Açıklaması",
                            ImageUrl = "3.jpg",
                            IsActive = true,
                            Name = "Iphone 15 Pro",
                            Price = 90000m,
                            Stock = 100
                        },
                        new
                        {
                            Id = 4,
                            Description = "Telefon Açıklaması",
                            ImageUrl = "4.jpg",
                            IsActive = false,
                            Name = "Iphone 16 Pro",
                            Price = 100000m,
                            Stock = 100
                        },
                        new
                        {
                            Id = 5,
                            Description = "Telefon Açıklaması",
                            ImageUrl = "5.jpg",
                            IsActive = true,
                            Name = "Iphone 17",
                            Price = 150000m,
                            Stock = 100
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
