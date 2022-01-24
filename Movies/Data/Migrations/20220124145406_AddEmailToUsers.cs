﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace Movies.Data.Migrations
{
    public partial class AddEmailToUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1ad6ef77-73fe-492f-bb24-ef5827eb7c8c",
                column: "ConcurrencyStamp",
                value: "a457c3dc-6c98-40d5-9ac2-148dd8957eef");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3747e4d8-78dc-4f55-8b38-ab5deea866fb",
                column: "ConcurrencyStamp",
                value: "17c3f637-6457-4650-98ad-7c9c80a87c8a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "101ab9b6-2b6e-494f-a72a-7ece0c979173",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b1a115d3-810c-4160-97c1-3762df49d8b9", "admin@admin.admin", "ADMIN@ADMIN.ADMIN", "AQAAAAEAACcQAAAAEM1pd8Y4rll4k+oET8XnvUcUr3qoL/5n1Hs8uvZFlflaQuexIPSOBORX2/dm5ylnUw==", "5429c92d-a59c-44da-a476-3b917f54bc2b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "69c272d3-1de9-4ca6-9c4d-61559167aa03",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "PasswordHash", "SecurityStamp" },
                values: new object[] { "84c8c047-8e5e-4926-b96b-57f0d275e2ef", "user@user.user", "USER@USER.USER", "AQAAAAEAACcQAAAAEMLetxATurDF1vKJwsLtthiR1Tkw5AelmVWS9whpNfriGXFo4F2wQWpWmp6WHwzE2g==", "fde0883c-cde8-4e83-a5ba-606a91f1920d" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1ad6ef77-73fe-492f-bb24-ef5827eb7c8c",
                column: "ConcurrencyStamp",
                value: "9101be03-d486-43c8-bb4f-ac8ade9aaec7");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3747e4d8-78dc-4f55-8b38-ab5deea866fb",
                column: "ConcurrencyStamp",
                value: "1dcc2486-58ae-496b-a793-0ffd0c3feefb");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "101ab9b6-2b6e-494f-a72a-7ece0c979173",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9b404c33-01f6-4afd-8c26-59f86b30e8bc", null, null, "AQAAAAEAACcQAAAAECME8aGLe8gm79tdWDnSVuUHdlpoxUuch1549ZF4NThDeO2iKsiYbEYh9bOvz7WFbQ==", "5c45ca93-19e1-4d94-a303-e6442ece3c7a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "69c272d3-1de9-4ca6-9c4d-61559167aa03",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8491464b-aeea-4ab4-93f7-76802d616729", null, null, "AQAAAAEAACcQAAAAEEq0o9fJjpmI8Xpr/pv9EVmpihbnSbG5QTUtCK0gQC2+G1ryeGEBFjabLqb+mPyp9g==", "78047a94-6e2b-48da-9faf-ba0c7b4ac299" });
        }
    }
}
