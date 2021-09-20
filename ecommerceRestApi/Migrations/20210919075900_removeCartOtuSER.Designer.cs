﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ecommerceRestApi.Models;

namespace ecommerceRestApi.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210919075900_removeCartOtuSER")]
    partial class removeCartOtuSER
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Amarket.Cart", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CartId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("Quantity")
                        .HasColumnType("float");

                    b.Property<double>("ShipmentFee")
                        .HasColumnType("float");

                    b.Property<double>("Tax")
                        .HasColumnType("float");

                    b.Property<double>("Total")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("Carts");
                });

            modelBuilder.Entity("Amarket.Order", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CartId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("PaymentOptionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("StatusId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("CartId")
                        .IsUnique();

                    b.HasIndex("PaymentOptionId");

                    b.HasIndex("StatusId");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Amarket.OrderStatus", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("OrderStatuses");
                });

            modelBuilder.Entity("Amarket.PaymentOption", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("OptionName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OptionValue")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PaymentOptions");
                });

            modelBuilder.Entity("Amarket.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Barcode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Brand")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LongDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<Guid>("ProductCategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ProductStatusId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ProductSubCategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("Quantity")
                        .HasColumnType("float");

                    b.Property<string>("SKU")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("SalePrice")
                        .HasColumnType("float");

                    b.Property<string>("ShortDescription")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ProductCategoryId");

                    b.HasIndex("ProductStatusId");

                    b.HasIndex("ProductSubCategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = new Guid("160c3fad-0479-4e35-9cd9-06427c4bc9e2"),
                            Barcode = "12341234234",
                            Brand = "Nike",
                            LongDescription = "100 % cotton absorbent, easy to dry shirt.",
                            Name = "Green Polo Long Sleeve",
                            Price = 200.0,
                            ProductCategoryId = new Guid("160c3fad-0479-4e35-9cd9-06427c4bc9e5"),
                            ProductStatusId = new Guid("160c3fad-0479-4e35-9cd9-06427c4bc9e5"),
                            ProductSubCategoryId = new Guid("160c3fad-0479-4e35-9cd9-06427c4bc9d2"),
                            Quantity = 100.0,
                            SKU = "SampleSKU",
                            SalePrice = 150.0,
                            ShortDescription = "Plain Green Polo long Sleeve"
                        },
                        new
                        {
                            Id = new Guid("160c3fad-0479-4e35-9cd9-06427c4bc9e5"),
                            Barcode = "12341234234324234",
                            Brand = "Nike",
                            LongDescription = "100 % cotton absorbent, easy to dry shirt.",
                            Name = "Plain White T-Shirt",
                            Price = 200.0,
                            ProductCategoryId = new Guid("160c3fad-0479-4e35-9cd9-06427c4bc9e5"),
                            ProductStatusId = new Guid("160c3fad-0479-4e35-9cd9-06427c4bc9e6"),
                            ProductSubCategoryId = new Guid("160c3fad-0479-4e35-9cd9-06427c4bc9d1"),
                            Quantity = 100.0,
                            SKU = "SampleSKUWhite",
                            SalePrice = 150.0,
                            ShortDescription = "Plain White T-shirt Round Neck"
                        });
                });

            modelBuilder.Entity("Amarket.ProductCategory", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ProductCategories");

                    b.HasData(
                        new
                        {
                            Id = new Guid("160c3fad-0479-4e35-9cd9-06427c4bc9e5"),
                            CategoryName = "Top Human Wear"
                        },
                        new
                        {
                            Id = new Guid("160c3fad-0479-4e35-9cd9-06427c4bc9e6"),
                            CategoryName = "Bottom Human Wear"
                        },
                        new
                        {
                            Id = new Guid("160c3fad-0479-4e35-9cd9-06427c4bc9e7"),
                            CategoryName = "Under Human Wear"
                        });
                });

            modelBuilder.Entity("Amarket.ProductImage", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ImageStatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ProductImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductImages");

                    b.HasData(
                        new
                        {
                            Id = new Guid("c060ef7e-9bef-46d8-b759-fa3b66bfaac2"),
                            ImageStatus = "Primary",
                            ProductId = new Guid("160c3fad-0479-4e35-9cd9-06427c4bc9e2"),
                            ProductImagePath = "greenPolo.jpg"
                        },
                        new
                        {
                            Id = new Guid("ec71cab4-11ce-4e33-bf1a-665163d88e19"),
                            ImageStatus = "Primary",
                            ProductId = new Guid("160c3fad-0479-4e35-9cd9-06427c4bc9e5"),
                            ProductImagePath = "shirt.png"
                        });
                });

            modelBuilder.Entity("Amarket.ProductStatus", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ProductStatuses");

                    b.HasData(
                        new
                        {
                            Id = new Guid("160c3fad-0479-4e35-9cd9-06427c4bc9e5"),
                            Status = "New Arrival"
                        },
                        new
                        {
                            Id = new Guid("160c3fad-0479-4e35-9cd9-06427c4bc9e6"),
                            Status = "New"
                        });
                });

            modelBuilder.Entity("Amarket.ProductSubCategory", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("SubCategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("ProductSubCategories");

                    b.HasData(
                        new
                        {
                            Id = new Guid("160c3fad-0479-4e35-9cd9-06427c4bc9d2"),
                            CategoryId = new Guid("160c3fad-0479-4e35-9cd9-06427c4bc9e5"),
                            SubCategoryName = "Polo"
                        },
                        new
                        {
                            Id = new Guid("160c3fad-0479-4e35-9cd9-06427c4bc9d1"),
                            CategoryId = new Guid("160c3fad-0479-4e35-9cd9-06427c4bc9e5"),
                            SubCategoryName = "T-Shirt"
                        });
                });

            modelBuilder.Entity("Amarket.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DeliveryNotes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MiddleInitial")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = new Guid("160c3fad-0479-4e35-9cd9-06427c4bc9e2"),
                            Address = "New York Continental Hotel",
                            ContactNumber = "+639772188156",
                            DeliveryNotes = "Text or call when you arrive.",
                            FirstName = "John",
                            LastName = "Wick",
                            MiddleInitial = "F"
                        });
                });

            modelBuilder.Entity("Amarket.Cart", b =>
                {
                    b.HasOne("Amarket.Product", "Products")
                        .WithOne("Cart")
                        .HasForeignKey("Amarket.Cart", "ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Products");
                });

            modelBuilder.Entity("Amarket.Order", b =>
                {
                    b.HasOne("Amarket.Cart", "Cart")
                        .WithOne("Order")
                        .HasForeignKey("Amarket.Order", "CartId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Amarket.PaymentOption", "PaymentOption")
                        .WithOne("Order")
                        .HasForeignKey("Amarket.Order", "PaymentOptionId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Amarket.OrderStatus", "Status")
                        .WithOne("Order")
                        .HasForeignKey("Amarket.Order", "StatusId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Amarket.User", "User")
                        .WithOne("Order")
                        .HasForeignKey("Amarket.Order", "UserId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Cart");

                    b.Navigation("PaymentOption");

                    b.Navigation("Status");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Amarket.Product", b =>
                {
                    b.HasOne("Amarket.ProductCategory", "Category")
                        .WithOne("Product")
                        .HasForeignKey("Amarket.Product", "ProductCategoryId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Amarket.ProductStatus", "Status")
                        .WithOne("Product")
                        .HasForeignKey("Amarket.Product", "ProductStatusId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Amarket.ProductSubCategory", "ProductSubCategory")
                        .WithOne("Product")
                        .HasForeignKey("Amarket.Product", "ProductSubCategoryId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("ProductSubCategory");

                    b.Navigation("Status");
                });

            modelBuilder.Entity("Amarket.ProductImage", b =>
                {
                    b.HasOne("Amarket.Product", "Product")
                        .WithMany("Image")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Amarket.ProductSubCategory", b =>
                {
                    b.HasOne("Amarket.ProductCategory", "Category")
                        .WithMany("ProductSubCategories")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Amarket.Cart", b =>
                {
                    b.Navigation("Order");
                });

            modelBuilder.Entity("Amarket.OrderStatus", b =>
                {
                    b.Navigation("Order");
                });

            modelBuilder.Entity("Amarket.PaymentOption", b =>
                {
                    b.Navigation("Order");
                });

            modelBuilder.Entity("Amarket.Product", b =>
                {
                    b.Navigation("Cart");

                    b.Navigation("Image");
                });

            modelBuilder.Entity("Amarket.ProductCategory", b =>
                {
                    b.Navigation("Product");

                    b.Navigation("ProductSubCategories");
                });

            modelBuilder.Entity("Amarket.ProductStatus", b =>
                {
                    b.Navigation("Product");
                });

            modelBuilder.Entity("Amarket.ProductSubCategory", b =>
                {
                    b.Navigation("Product");
                });

            modelBuilder.Entity("Amarket.User", b =>
                {
                    b.Navigation("Order");
                });
#pragma warning restore 612, 618
        }
    }
}