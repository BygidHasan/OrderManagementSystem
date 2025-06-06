﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OrderManagement.Infrastructure.Data;

#nullable disable

namespace OrderManagement.Infrastructure.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20250522140456_UpdateSeedData")]
    partial class UpdateSeedData
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.5");

            modelBuilder.Entity("OrderManagement.Domain.Entities.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CustomerName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Quantity")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Orders");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CustomerName = "Alice Smith",
                            OrderDate = new DateTime(2025, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProductName = "Laptop",
                            Quantity = 1
                        },
                        new
                        {
                            Id = 2,
                            CustomerName = "Bob Smith",
                            OrderDate = new DateTime(2025, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProductName = "Smartphone",
                            Quantity = 2
                        },
                        new
                        {
                            Id = 3,
                            CustomerName = "John Doe",
                            OrderDate = new DateTime(2025, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProductName = "Tablet",
                            Quantity = 3
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
