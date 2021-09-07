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

            User u = new User()
            {
                Id = Guid.Parse("160c3fad-0479-4e35-9cd9-06427c4bc9e2"),
                FirstName = "John",
                LastName = "Wick",
                MiddleInitial = "F",
                Address = "New York Continental Hotel",
                ContactNumber = "+639772188156",
                DeliveryNotes = "Text or call when you arrive."
            };
            modelBuilder.Entity<User>().HasData(u);

            ProductCategory pc = new ProductCategory() { 
                Id= Guid.Parse("160c3fad-0479-4e35-9cd9-06427c4bc9e5"),
                CategoryName = "Top Human Wear"
            };
            ProductCategory pc1 = new ProductCategory()
            {
                Id = Guid.Parse("160c3fad-0479-4e35-9cd9-06427c4bc9e6"),
                CategoryName = "Bottom Human Wear"
            };
            ProductCategory pc2 = new ProductCategory()
            {
                Id = Guid.Parse("160c3fad-0479-4e35-9cd9-06427c4bc9e7"),
                CategoryName = "Under Human Wear"
            };

            //PRODUCT CATEGORY DATA
            modelBuilder.Entity<ProductCategory>().HasData(pc);
            modelBuilder.Entity<ProductCategory>().HasData(pc1);
            modelBuilder.Entity<ProductCategory>().HasData(pc2);

            ProductSubCategory psc = new ProductSubCategory()
            {
                Id = Guid.Parse("160c3fad-0479-4e35-9cd9-06427c4bc9d2"),
                CategoryId = Guid.Parse("160c3fad-0479-4e35-9cd9-06427c4bc9e5"),
                SubCategoryName = "Polo"
            };
            ProductSubCategory psc2 = new ProductSubCategory()
            {
                Id = Guid.Parse("160c3fad-0479-4e35-9cd9-06427c4bc9d1"),
                CategoryId = Guid.Parse("160c3fad-0479-4e35-9cd9-06427c4bc9e5"),
                SubCategoryName ="T-Shirt"
            };

            //PRODUCT SUBCATEGORY DATA
            modelBuilder.Entity<ProductSubCategory>().HasData(psc);
            modelBuilder.Entity<ProductSubCategory>().HasData(psc2);

            ProductStatus ps = new ProductStatus() {
                Id = Guid.Parse("160c3fad-0479-4e35-9cd9-06427c4bc9e5"),
                Status = "New Arrival"           
            };
            ProductStatus ps2 = new ProductStatus()
            {
                Id = Guid.Parse("160c3fad-0479-4e35-9cd9-06427c4bc9e6"),
                Status = "New"
            };
            //PRODUCT STATUS DATA
            modelBuilder.Entity<ProductStatus>().HasData(ps);
            modelBuilder.Entity<ProductStatus>().HasData(ps2);

            Product product1 = new Product()
            {
                Id = Guid.Parse("160c3fad-0479-4e35-9cd9-06427c4bc9e2"),
                Name = "Green Polo Long Sleeve",
                Quantity = 100,
                Price = 200,
                SalePrice = 150,
                Brand = "Nike",
                ShortDescription = "Plain Green Polo long Sleeve",
                LongDescription = "100 % cotton absorbent, easy to dry shirt.",
                SKU = "SampleSKU",
                Barcode = "12341234234",
                ProductStatusId = Guid.Parse("160c3fad-0479-4e35-9cd9-06427c4bc9e5"),
                ProductCategoryId = Guid.Parse("160c3fad-0479-4e35-9cd9-06427c4bc9e5"),
                ProductSubCategoryId = Guid.Parse("160c3fad-0479-4e35-9cd9-06427c4bc9d2")

            };

            Product product2 = new Product()
            {
                Id = Guid.Parse("160c3fad-0479-4e35-9cd9-06427c4bc9e5"),
                Name = "Plain White T-Shirt",
                Quantity = 100,
                Price = 200,
                SalePrice = 150,
                Brand = "Nike",
                ShortDescription = "Plain White T-shirt Round Neck",
                LongDescription = "100 % cotton absorbent, easy to dry shirt.",
                SKU = "SampleSKUWhite",
                Barcode = "12341234234324234",
                ProductStatusId = Guid.Parse("160c3fad-0479-4e35-9cd9-06427c4bc9e6"),
                ProductCategoryId = Guid.Parse("160c3fad-0479-4e35-9cd9-06427c4bc9e5"),
                ProductSubCategoryId = Guid.Parse("160c3fad-0479-4e35-9cd9-06427c4bc9d1")
            };

            //PRODUCT DATA
            modelBuilder.Entity<Product>().HasData(product1);
            modelBuilder.Entity<Product>().HasData(product2);


            ProductImage pi = new ProductImage() { 
                Id = Guid.NewGuid(),
                ProductId = Guid.Parse("160c3fad-0479-4e35-9cd9-06427c4bc9e2"),
                ProductImagePath = "greenPolo.jpg",
                ImageStatus = "Primary"
            };

            ProductImage pi2 = new ProductImage()
            {
                Id = Guid.NewGuid(),
                ProductId = Guid.Parse("160c3fad-0479-4e35-9cd9-06427c4bc9e5"),
                ProductImagePath = "shirt.png",
                ImageStatus = "Primary"
            };

            //PRODUCT DATA
            modelBuilder.Entity<ProductImage>().HasData(pi);
            modelBuilder.Entity<ProductImage>().HasData(pi2);

        }




    }
}
