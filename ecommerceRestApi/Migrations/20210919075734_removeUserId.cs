using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ecommerceRestApi.Migrations
{
    public partial class removeUserId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Carts_Users_UserId",
                table: "Carts");

            migrationBuilder.DropIndex(
                name: "IX_Carts_UserId",
                table: "Carts");

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: new Guid("b5b830d2-88fe-43fe-8721-377250ffef86"));

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: new Guid("e0dc684c-880d-42aa-8f7d-1538a6928d9a"));

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Carts");

            migrationBuilder.AddColumn<Guid>(
                name: "CartId",
                table: "Users",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "Id", "ImageStatus", "ProductId", "ProductImagePath" },
                values: new object[] { new Guid("81aa44f1-98ab-45f1-96fe-2fccec83e3f1"), "Primary", new Guid("160c3fad-0479-4e35-9cd9-06427c4bc9e2"), "greenPolo.jpg" });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "Id", "ImageStatus", "ProductId", "ProductImagePath" },
                values: new object[] { new Guid("d22ffb81-5091-4dfe-a02b-6a2510569005"), "Primary", new Guid("160c3fad-0479-4e35-9cd9-06427c4bc9e5"), "shirt.png" });

            migrationBuilder.CreateIndex(
                name: "IX_Users_CartId",
                table: "Users",
                column: "CartId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Carts_CartId",
                table: "Users",
                column: "CartId",
                principalTable: "Carts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Carts_CartId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_CartId",
                table: "Users");

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: new Guid("81aa44f1-98ab-45f1-96fe-2fccec83e3f1"));

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: new Guid("d22ffb81-5091-4dfe-a02b-6a2510569005"));

            migrationBuilder.DropColumn(
                name: "CartId",
                table: "Users");

            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "Carts",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "Id", "ImageStatus", "ProductId", "ProductImagePath" },
                values: new object[] { new Guid("b5b830d2-88fe-43fe-8721-377250ffef86"), "Primary", new Guid("160c3fad-0479-4e35-9cd9-06427c4bc9e2"), "greenPolo.jpg" });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "Id", "ImageStatus", "ProductId", "ProductImagePath" },
                values: new object[] { new Guid("e0dc684c-880d-42aa-8f7d-1538a6928d9a"), "Primary", new Guid("160c3fad-0479-4e35-9cd9-06427c4bc9e5"), "shirt.png" });

            migrationBuilder.CreateIndex(
                name: "IX_Carts_UserId",
                table: "Carts",
                column: "UserId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Carts_Users_UserId",
                table: "Carts",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
