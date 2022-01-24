using Microsoft.EntityFrameworkCore.Migrations;

namespace Movies.Data.Migrations
{
    public partial class UpdateUserPasswords : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "73cdee5c-0000-48e2-8925-c6d1c5eb33b6", "AQAAAAEAACcQAAAAEMIHZtOtIVmf4/lMinqAuMplBbHiSYNIdRzIBgGLsGcOm8bTtKu0OgH4iCoYg5z8Rw==", "2af80c4d-1f2d-49ca-8278-823eb3459ce9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "69c272d3-1de9-4ca6-9c4d-61559167aa03",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c003f7b3-4c17-46e2-9084-de1e9b00ec71", "AQAAAAEAACcQAAAAEG6Wy3Ske/XGP3Bv4kp9dCuLQx8P8ljNPnCFUDiLdSh1PTuIPFXxqtYHnOeK2HFUig==", "dd1e7799-da30-4a65-9df4-120b922e2e3b" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1de09893-fbbc-43db-b859-f24c5961e444", "AQAAAAEAACcQAAAAEJIsOx9905wblFlXRhGBhePbHueMEGPST88ktAk+6TMMrlr8R3IBfgKawtlDoNLOaw==", "178c1724-e012-401a-bdbc-941b2d2ef858" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "69c272d3-1de9-4ca6-9c4d-61559167aa03",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0329a6d1-9f16-4180-9e7f-b9c303fae5a9", "AQAAAAEAACcQAAAAEHK2rpG0ia6YE5pLNVJOapbuMATGELWhrpVRKuJkxZ+FxJKVdyO+FHGLsBPXrsmo/Q==", "6b219172-2fb5-41de-a113-6c33f8e6a9b9" });
        }
    }
}
