using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ecommerceRestApi.Migrations
{
    public partial class removeUserToCartRel : Migration
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
                keyValue: new Guid("019b6a59-1d15-4af7-bea6-301311b22793"));

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: new Guid("e8f4ba00-ccc9-473b-ae5d-bab4423f2ad2"));

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "Id", "ImageStatus", "ProductId", "ProductImagePath" },
                values: new object[] { new Guid("019b6a59-1d15-4af7-bea6-301311b22793"), "Primary", new Guid("160c3fad-0479-4e35-9cd9-06427c4bc9e2"), "greenPolo.jpg" });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "Id", "ImageStatus", "ProductId", "ProductImagePath" },
                values: new object[] { new Guid("e8f4ba00-ccc9-473b-ae5d-bab4423f2ad2"), "Primary", new Guid("160c3fad-0479-4e35-9cd9-06427c4bc9e5"), "shirt.png" });

            migrationBuilder.CreateIndex(
                name: "IX_Carts_UserId",
                table: "Carts",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Carts_Users_UserId",
                table: "Carts",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");
        }
    }
}
