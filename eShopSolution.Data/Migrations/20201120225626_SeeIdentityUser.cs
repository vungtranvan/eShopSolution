using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class SeeIdentityUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                nullable: false,
                defaultValue: new DateTime(2020, 11, 21, 5, 56, 26, 76, DateTimeKind.Local).AddTicks(205),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 11, 21, 5, 41, 22, 511, DateTimeKind.Local).AddTicks(3992));

            migrationBuilder.InsertData(
                table: "AppRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[] { new Guid("cbf31616-0169-4db7-8198-f16e44ce1c14"), "f6e870e2-8c82-4576-9f26-b68e3ca7e56f", "Administrator role", "admin", "admin" });

            migrationBuilder.InsertData(
                table: "AppUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { new Guid("8497c341-ffbf-4787-8ca9-1a91e6ab2c3d"), new Guid("cbf31616-0169-4db7-8198-f16e44ce1c14") });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Dob", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("8497c341-ffbf-4787-8ca9-1a91e6ab2c3d"), 0, "881fba46-4b5f-4830-acee-757a5a0a399e", new DateTime(2020, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "vungka321@gmail.com", true, "Tran", "Vung", false, null, "vungka321@gmail.com", "admin", "AQAAAAEAACcQAAAAEIyXm3TLqWCgMcz0tmsDf/C0gLTwOgNKqSANz/22GmFHbu2XwOOCKndClDzZ6Q9pyw==", null, false, "", false, "admin" });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("cbf31616-0169-4db7-8198-f16e44ce1c14"));

            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("8497c341-ffbf-4787-8ca9-1a91e6ab2c3d"), new Guid("cbf31616-0169-4db7-8198-f16e44ce1c14") });

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("8497c341-ffbf-4787-8ca9-1a91e6ab2c3d"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 11, 21, 5, 41, 22, 511, DateTimeKind.Local).AddTicks(3992),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 11, 21, 5, 56, 26, 76, DateTimeKind.Local).AddTicks(205));

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
                value: new DateTime(2020, 11, 21, 5, 41, 22, 528, DateTimeKind.Local).AddTicks(1345));
        }
    }
}
