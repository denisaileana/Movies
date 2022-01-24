using Microsoft.EntityFrameworkCore.Migrations;

namespace Movies.Data.Migrations
{
    public partial class AddUsersAndRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3747e4d8-78dc-4f55-8b38-ab5deea866fb", "1dcc2486-58ae-496b-a793-0ffd0c3feefb", "Administrator", "ADMINISTRATOR" },
                    { "1ad6ef77-73fe-492f-bb24-ef5827eb7c8c", "9101be03-d486-43c8-bb4f-ac8ade9aaec7", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "101ab9b6-2b6e-494f-a72a-7ece0c979173", 0, "9b404c33-01f6-4afd-8c26-59f86b30e8bc", null, false, false, null, null, "ADMIN", "AQAAAAEAACcQAAAAECME8aGLe8gm79tdWDnSVuUHdlpoxUuch1549ZF4NThDeO2iKsiYbEYh9bOvz7WFbQ==", null, false, "5c45ca93-19e1-4d94-a303-e6442ece3c7a", false, "admin" },
                    { "69c272d3-1de9-4ca6-9c4d-61559167aa03", 0, "8491464b-aeea-4ab4-93f7-76802d616729", null, false, false, null, null, "USER", "AQAAAAEAACcQAAAAEEq0o9fJjpmI8Xpr/pv9EVmpihbnSbG5QTUtCK0gQC2+G1ryeGEBFjabLqb+mPyp9g==", null, false, "78047a94-6e2b-48da-9faf-ba0c7b4ac299", false, "user" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "3747e4d8-78dc-4f55-8b38-ab5deea866fb", "101ab9b6-2b6e-494f-a72a-7ece0c979173" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "1ad6ef77-73fe-492f-bb24-ef5827eb7c8c", "101ab9b6-2b6e-494f-a72a-7ece0c979173" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "1ad6ef77-73fe-492f-bb24-ef5827eb7c8c", "69c272d3-1de9-4ca6-9c4d-61559167aa03" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1ad6ef77-73fe-492f-bb24-ef5827eb7c8c", "101ab9b6-2b6e-494f-a72a-7ece0c979173" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3747e4d8-78dc-4f55-8b38-ab5deea866fb", "101ab9b6-2b6e-494f-a72a-7ece0c979173" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1ad6ef77-73fe-492f-bb24-ef5827eb7c8c", "69c272d3-1de9-4ca6-9c4d-61559167aa03" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1ad6ef77-73fe-492f-bb24-ef5827eb7c8c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3747e4d8-78dc-4f55-8b38-ab5deea866fb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "101ab9b6-2b6e-494f-a72a-7ece0c979173");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "69c272d3-1de9-4ca6-9c4d-61559167aa03");
        }
    }
}
