using Amarket;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ecommerceRestApi.Models
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Order> Orders { get; set; }

        public DbSet<PaymentOption> PaymentOptions { get; set; }

        public DbSet<OrderStatus> OrderStatuses { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductStatus> ProductStatuses { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<ProductSubCategory> ProductSubCategories { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        // public DbSet<ProductVideo> ProductVideos { get; set; }
        //public DbSet<ProductDistinctFeatures> ProductDistinctFeatures { get; set; }


        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //one to one
            //INSTRUCTION
            //1. Establish the relationship first before seeding
            //2. In one to one relationship, create the Pricipal table first and specify the foreign key as well as the other data
            //3. call the HASDATA method
            //4. Add-migration and update-database
            //5. Once the Parent table is created and it's data is seeded, create the Child object after the HasData()
            //6. Make Sure that it's primary id is exactly the same as to that of the principal key specified in the relationship
            //7. Remember not to seed all at once but table per table. Rule is that parent table must exists first before the child table


            //PRODUCT TO STATUS
            modelBuilder.Entity<ProductStatus>()
                .HasOne(status => status.Product)
                .WithOne(product => product.Status)
                .HasForeignKey<Product>(product => product.ProductStatusId)
                .HasPrincipalKey<ProductStatus>(ps => ps.Id)
                .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Product>()
               .Property(i => i.ProductStatusId).HasColumnType("uniqueidentifier").IsRequired(true);
            modelBuilder.Entity<Product>().HasIndex("ProductStatusId").IsUnique(false);
            //PRODUCT TO CATEGORY RELATIONSHIP
            modelBuilder.Entity<ProductCategory>()
                .HasOne(pc=>pc.Product)
                .WithOne(c=>c.Category)
                .HasForeignKey<Product>(p=>p.ProductCategoryId)
                .HasPrincipalKey<ProductCategory>(pc=>pc.Id)
                .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Product>()
                .Property(i => i.ProductCategoryId).HasColumnType("uniqueidentifier").IsRequired(true);
            modelBuilder.Entity<Product>().HasIndex("ProductCategoryId").IsUnique(false);
            //PRODUCT TO SUBCATEGORY RELATIONSHIP
            modelBuilder.Entity<ProductSubCategory>()
                .HasOne(psc =>psc.Product)
                .WithOne(p=>p.ProductSubCategory)
                .HasForeignKey<Product>(p=>p.ProductSubCategoryId)
                .HasPrincipalKey<ProductSubCategory>(psc=>psc.Id)
                .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Product>()
               .Property(i => i.ProductSubCategoryId).HasColumnType("uniqueidentifier").IsRequired(true);
            modelBuilder.Entity<Product>().HasIndex("ProductSubCategoryId").IsUnique(false);
            //CATEGORY TO SUBCATEGORY RELATIONSHIP
            modelBuilder.Entity<ProductCategory>()
            .HasMany(pc => pc.ProductSubCategories)
            .WithOne(psc => psc.Category)
            .HasForeignKey(psc => psc.CategoryId)
            .HasPrincipalKey(pc => pc.Id)
             .OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<ProductSubCategory>()
               .Property(i => i.CategoryId).HasColumnType("uniqueidentifier").IsRequired(true);
            modelBuilder.Entity<ProductSubCategory>().HasIndex("CategoryId").IsUnique(false);
            //PRODUCT TO IMAGE RELATIONSHIP
            modelBuilder.Entity<Product>()
                .HasMany(p => p.Image)
                .WithOne(i => i.Product)
                .HasForeignKey(i => i.ProductId)
                .HasPrincipalKey(p => p.Id)
                .OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<ProductImage>()
               .Property(i => i.ProductId).HasColumnType("uniqueidentifier").IsRequired(true);
            modelBuilder.Entity<ProductImage>().HasIndex("ProductId").IsUnique(false);
            //USER TO CART
            modelBuilder.Entity<User>()
                .HasOne(u => u.Cart)
                .WithOne(c => c.User)
                .HasForeignKey<Cart>(c=>c.UserId)
                .HasPrincipalKey<User>(u => u.Id)
                .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Cart>()
               .Property(cart=>cart.UserId).HasColumnType("uniqueidentifier").IsRequired(true);
            modelBuilder.Entity<Cart>().HasIndex("UserId").IsUnique(false);
            //Cart to Products
            modelBuilder.Entity<Product>()
                .HasOne(p => p.Cart)
                .WithOne(c => c.Products)
                .HasForeignKey<Cart>(c => c.ProductId) 
                .HasPrincipalKey<Product>(p => p.Id);

            modelBuilder.Entity<Cart>()
                .Property(c => c.ProductId).HasColumnType("uniqueidentifier").IsRequired(true);
            modelBuilder.Entity<Cart>().HasIndex("ProductId").IsUnique(false);
            //Order to User
            modelBuilder.Entity<Order>()
                .HasOne(o => o.User)
                .WithOne(u => u.Order)
                .HasForeignKey<Order>(o => o.UserId)
                .HasPrincipalKey<User>(u => u.Id)
                .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Order>()
               .Property(i => i.UserId).HasColumnType("uniqueidentifier").IsRequired(true);
            modelBuilder.Entity<Order>().HasIndex("UserId").IsUnique(false);
            //Order to Cart
            modelBuilder.Entity<Order>()
                .HasOne(o => o.Cart)
                .WithOne(c => c.Order)
                .HasForeignKey<Order>(o => o.CartId)
                .HasPrincipalKey<Cart>(c => c.Id);
            modelBuilder.Entity<Order>()
              .Property(i => i.CartId).HasColumnType("uniqueidentifier").IsRequired(true);
            modelBuilder.Entity<Order>().HasIndex("CartId").IsUnique(true);//one order has a unique card id
            //Order to paymentOptions
            modelBuilder.Entity<Order>()
                .HasOne(o => o.PaymentOption)
                .WithOne(p => p.Order)
                .HasForeignKey<Order>(o => o.PaymentOptionId)
                .HasPrincipalKey<PaymentOption>(po => po.Id)
                .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Order>()
              .Property(i => i.PaymentOptionId).HasColumnType("uniqueidentifier").IsRequired(true);
            modelBuilder.Entity<Order>().HasIndex("PaymentOptionId").IsUnique(false);
            //Order to OrderStatus

            modelBuilder.Entity<Order>()
                .HasOne(o => o.Status)
                .WithOne(s => s.Order)
                .HasForeignKey<Order>(o => o.StatusId)
                .HasPrincipalKey<OrderStatus>(os => os.Id)
                .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Order>()
             .Property(i => i.StatusId).HasColumnType("uniqueidentifier").IsRequired(true);
            modelBuilder.Entity<Order>().HasIndex("StatusId").IsUnique(false);

        }




    }
}
