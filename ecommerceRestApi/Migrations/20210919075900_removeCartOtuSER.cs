using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ecommerceRestApi.Migrations
{
    public partial class removeCartOtuSER : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "Id", "ImageStatus", "ProductId", "ProductImagePath" },
                values: new object[] { new Guid("c060ef7e-9bef-46d8-b759-fa3b66bfaac2"), "Primary", new Guid("160c3fad-0479-4e35-9cd9-06427c4bc9e2"), "greenPolo.jpg" });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "Id", "ImageStatus", "ProductId", "ProductImagePath" },
                values: new object[] { new Guid("ec71cab4-11ce-4e33-bf1a-665163d88e19"), "Primary", new Guid("160c3fad-0479-4e35-9cd9-06427c4bc9e5"), "shirt.png" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: new Guid("c060ef7e-9bef-46d8-b759-fa3b66bfaac2"));

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: new Guid("ec71cab4-11ce-4e33-bf1a-665163d88e19"));

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
    }
}
