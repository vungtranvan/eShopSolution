using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class ProductImageTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 11, 21, 5, 56, 26, 76, DateTimeKind.Local).AddTicks(205));

            migrationBuilder.CreateTable(
                name: "ProductImages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(nullable: false),
                    ImagePath = table.Column<string>(maxLength: 200, nullable: false),
                    Caption = table.Column<string>(maxLength: 200, nullable: true),
                    IsDefault = table.Column<bool>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    SortOrder = table.Column<int>(nullable: false),
                    FileSize = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductImages_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("cbf31616-0169-4db7-8198-f16e44ce1c14"),
                column: "ConcurrencyStamp",
                value: "6d374840-6054-427a-af2d-b63ade09c648");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("8497c341-ffbf-4787-8ca9-1a91e6ab2c3d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "26f9f645-06f6-4507-9d8e-556322b036d7", "AQAAAAEAACcQAAAAEAiTGAAPvLKnTQBfZgwZcGqdGcyciAuKmZD7cNis2AS3xua7YzuyO7Z1CRUxE/bFZQ==" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2020, 11, 21, 17, 47, 34, 722, DateTimeKind.Local).AddTicks(3382));

            migrationBuilder.CreateIndex(
                name: "IX_ProductImages_ProductId",
                table: "ProductImages",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductImages");

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 11, 21, 5, 56, 26, 76, DateTimeKind.Local).AddTicks(205),
                oldClrType: typeof(DateTime));

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("cbf31616-0169-4db7-8198-f16e44ce1c14"),
                column: "ConcurrencyStamp",
                value: "f6e870e2-8c82-4576-9f26-b68e3ca7e56f");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("8497c341-ffbf-4787-8ca9-1a91e6ab2c3d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "881fba46-4b5f-4830-acee-757a5a0a399e", "AQAAAAEAACcQAAAAEIyXm3TLqWCgMcz0tmsDf/C0gLTwOgNKqSANz/22GmFHbu2XwOOCKndClDzZ6Q9pyw==" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2020, 11, 21, 5, 56, 26, 93, DateTimeKind.Local).AddTicks(367));
        }
    }
}
