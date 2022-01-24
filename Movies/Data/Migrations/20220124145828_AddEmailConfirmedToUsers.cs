using Microsoft.EntityFrameworkCore.Migrations;

namespace Movies.Data.Migrations
{
    public partial class AddEmailConfirmedToUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1ad6ef77-73fe-492f-bb24-ef5827eb7c8c",
                column: "ConcurrencyStamp",
                value: "edfaf507-13e7-4350-ba7c-6007b24a8296");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3747e4d8-78dc-4f55-8b38-ab5deea866fb",
                column: "ConcurrencyStamp",
                value: "e7fee9b1-2d8e-409e-a057-9e6720dc9f9b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "101ab9b6-2b6e-494f-a72a-7ece0c979173",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1de09893-fbbc-43db-b859-f24c5961e444", true, "AQAAAAEAACcQAAAAEJIsOx9905wblFlXRhGBhePbHueMEGPST88ktAk+6TMMrlr8R3IBfgKawtlDoNLOaw==", "178c1724-e012-401a-bdbc-941b2d2ef858" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "69c272d3-1de9-4ca6-9c4d-61559167aa03",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0329a6d1-9f16-4180-9e7f-b9c303fae5a9", true, "AQAAAAEAACcQAAAAEHK2rpG0ia6YE5pLNVJOapbuMATGELWhrpVRKuJkxZ+FxJKVdyO+FHGLsBPXrsmo/Q==", "6b219172-2fb5-41de-a113-6c33f8e6a9b9" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b1a115d3-810c-4160-97c1-3762df49d8b9", false, "AQAAAAEAACcQAAAAEM1pd8Y4rll4k+oET8XnvUcUr3qoL/5n1Hs8uvZFlflaQuexIPSOBORX2/dm5ylnUw==", "5429c92d-a59c-44da-a476-3b917f54bc2b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "69c272d3-1de9-4ca6-9c4d-61559167aa03",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "84c8c047-8e5e-4926-b96b-57f0d275e2ef", false, "AQAAAAEAACcQAAAAEMLetxATurDF1vKJwsLtthiR1Tkw5AelmVWS9whpNfriGXFo4F2wQWpWmp6WHwzE2g==", "fde0883c-cde8-4e83-a5ba-606a91f1920d" });
        }
    }
}
