using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class ChangerFileLengthType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "FileSize",
                table: "ProductImages",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("cbf31616-0169-4db7-8198-f16e44ce1c14"),
                column: "ConcurrencyStamp",
                value: "5621b97f-6766-4cef-b6c7-e2785ab557fe");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("8497c341-ffbf-4787-8ca9-1a91e6ab2c3d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "53636c3e-100d-431b-a9ef-b694e68dabc5", "AQAAAAEAACcQAAAAEGcdnlCKqePQmPcHRySvq3Z46WIFjxbgBQm+D8NCwZICO1ULxxVArZStR6Vtvb6Ycw==" });

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
                value: new DateTime(2020, 11, 21, 18, 56, 9, 52, DateTimeKind.Local).AddTicks(5802));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "FileSize",
                table: "ProductImages",
                type: "int",
                nullable: false,
                oldClrType: typeof(long));

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
        }
    }
}
