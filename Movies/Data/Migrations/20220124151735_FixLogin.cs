using Microsoft.EntityFrameworkCore.Migrations;

namespace Movies.Data.Migrations
{
    public partial class FixLogin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1ad6ef77-73fe-492f-bb24-ef5827eb7c8c",
                column: "ConcurrencyStamp",
                value: "460b1377-c391-4745-a103-c602d8e8b278");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3747e4d8-78dc-4f55-8b38-ab5deea866fb",
                column: "ConcurrencyStamp",
                value: "b484d7c0-ca25-4227-a66b-0fd5b788097c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "101ab9b6-2b6e-494f-a72a-7ece0c979173",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "SecurityStamp", "UserName" },
                values: new object[] { "22d38046-d974-4dcc-a69d-b496a8414349", "ADMIN@ADMIN.ADMIN", "1f89816a-fd1d-4b53-83d2-1728dd206d57", "admin@admin.admin" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "69c272d3-1de9-4ca6-9c4d-61559167aa03",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "5f64a249-c14b-44bb-997f-f2e7ad44fcb7", "USER@USER.USER", "AQAAAAEAACcQAAAAEAjVkzb9W4HEmgTsG5nAZTenHGCYkG79YPpidwLG3mGYEHDUGf3eau5Ze+lo52mU4w==", "3beba814-496e-4580-ab6c-7de57717e3af", "user@user.user" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1ad6ef77-73fe-492f-bb24-ef5827eb7c8c",
                column: "ConcurrencyStamp",
                value: "71fbafc5-4423-4cd7-99d2-6fa54a847a6b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3747e4d8-78dc-4f55-8b38-ab5deea866fb",
                column: "ConcurrencyStamp",
                value: "e838c5ce-4c37-4ab2-a3da-8dd29107cf81");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "101ab9b6-2b6e-494f-a72a-7ece0c979173",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "SecurityStamp", "UserName" },
                values: new object[] { "73cdee5c-0000-48e2-8925-c6d1c5eb33b6", "ADMIN", "2af80c4d-1f2d-49ca-8278-823eb3459ce9", "admin" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "69c272d3-1de9-4ca6-9c4d-61559167aa03",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "c003f7b3-4c17-46e2-9084-de1e9b00ec71", "USER", "AQAAAAEAACcQAAAAEG6Wy3Ske/XGP3Bv4kp9dCuLQx8P8ljNPnCFUDiLdSh1PTuIPFXxqtYHnOeK2HFUig==", "dd1e7799-da30-4a65-9df4-120b922e2e3b", "user" });
        }
    }
}
