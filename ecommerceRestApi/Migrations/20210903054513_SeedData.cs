using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ecommerceRestApi.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "Id", "CategoryName" },
                values: new object[,]
                {
                    { new Guid("160c3fad-0479-4e35-9cd9-06427c4bc9e5"), "Top Human Wear" },
                    { new Guid("160c3fad-0479-4e35-9cd9-06427c4bc9e6"), "Bottom Human Wear" },
                    { new Guid("160c3fad-0479-4e35-9cd9-06427c4bc9e7"), "Under Human Wear" }
                });

            migrationBuilder.InsertData(
                table: "ProductStatuses",
                columns: new[] { "Id", "Status" },
                values: new object[,]
                {
                    { new Guid("160c3fad-0479-4e35-9cd9-06427c4bc9e5"), "New Arrival" },
                    { new Guid("160c3fad-0479-4e35-9cd9-06427c4bc9e6"), "New" }
                });

            migrationBuilder.InsertData(
                table: "ProductSubCategories",
                columns: new[] { "Id", "CategoryId", "SubCategoryName" },
                values: new object[] { new Guid("160c3fad-0479-4e35-9cd9-06427c4bc9d2"), new Guid("160c3fad-0479-4e35-9cd9-06427c4bc9e5"), "Polo" });

            migrationBuilder.InsertData(
                table: "ProductSubCategories",
                columns: new[] { "Id", "CategoryId", "SubCategoryName" },
                values: new object[] { new Guid("160c3fad-0479-4e35-9cd9-06427c4bc9d1"), new Guid("160c3fad-0479-4e35-9cd9-06427c4bc9e5"), "T-Shirt" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Barcode", "Brand", "LongDescription", "Name", "Price", "ProductCategoryId", "ProductStatusId", "ProductSubCategoryId", "Quantity", "SKU", "SalePrice", "ShortDescription" },
                values: new object[] { new Guid("160c3fad-0479-4e35-9cd9-06427c4bc9e2"), "12341234234", "Nike", "100 % cotton absorbent, easy to dry shirt.", "Green Polo Long Sleeve", 200.0, new Guid("160c3fad-0479-4e35-9cd9-06427c4bc9e5"), new Guid("160c3fad-0479-4e35-9cd9-06427c4bc9e5"), new Guid("160c3fad-0479-4e35-9cd9-06427c4bc9d2"), 100.0, "SampleSKU", 150.0, "Plain Green Polo long Sleeve" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Barcode", "Brand", "LongDescription", "Name", "Price", "ProductCategoryId", "ProductStatusId", "ProductSubCategoryId", "Quantity", "SKU", "SalePrice", "ShortDescription" },
                values: new object[] { new Guid("160c3fad-0479-4e35-9cd9-06427c4bc9e5"), "12341234234324234", "Nike", "100 % cotton absorbent, easy to dry shirt.", "Plain White T-Shirt", 200.0, new Guid("160c3fad-0479-4e35-9cd9-06427c4bc9e5"), new Guid("160c3fad-0479-4e35-9cd9-06427c4bc9e6"), new Guid("160c3fad-0479-4e35-9cd9-06427c4bc9d1"), 100.0, "SampleSKUWhite", 150.0, "Plain White T-shirt Round Neck" });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "Id", "ImageStatus", "ProductId", "ProductImagePath" },
                values: new object[] { new Guid("e0352f54-73b9-4973-a692-c32a1ddecac5"), "Primary", new Guid("160c3fad-0479-4e35-9cd9-06427c4bc9e2"), "greenPolo.jpg" });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "Id", "ImageStatus", "ProductId", "ProductImagePath" },
                values: new object[] { new Guid("2e593560-3762-4cca-9b5e-a621c7ad6b01"), "Primary", new Guid("160c3fad-0479-4e35-9cd9-06427c4bc9e5"), "shirt.png" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("160c3fad-0479-4e35-9cd9-06427c4bc9e6"));

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("160c3fad-0479-4e35-9cd9-06427c4bc9e7"));

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: new Guid("2e593560-3762-4cca-9b5e-a621c7ad6b01"));

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: new Guid("e0352f54-73b9-4973-a692-c32a1ddecac5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("160c3fad-0479-4e35-9cd9-06427c4bc9e2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("160c3fad-0479-4e35-9cd9-06427c4bc9e5"));

            migrationBuilder.DeleteData(
                table: "ProductStatuses",
                keyColumn: "Id",
                keyValue: new Guid("160c3fad-0479-4e35-9cd9-06427c4bc9e5"));

            migrationBuilder.DeleteData(
                table: "ProductStatuses",
                keyColumn: "Id",
                keyValue: new Guid("160c3fad-0479-4e35-9cd9-06427c4bc9e6"));

            migrationBuilder.DeleteData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("160c3fad-0479-4e35-9cd9-06427c4bc9d1"));

            migrationBuilder.DeleteData(
                table: "ProductSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("160c3fad-0479-4e35-9cd9-06427c4bc9d2"));

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("160c3fad-0479-4e35-9cd9-06427c4bc9e5"));
        }
    }
}
