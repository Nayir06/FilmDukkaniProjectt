using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FilmDukkanı.DAL.Migrations
{
    public partial class denene2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "IsActive", "MasterId", "Status" },
                values: new object[] { new DateTime(2023, 7, 9, 22, 12, 15, 946, DateTimeKind.Local).AddTicks(2822), true, new Guid("79f21f7c-ce6e-450b-aff3-5bbf10421fae"), 1 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "IsActive", "MasterId", "Status" },
                values: new object[] { new DateTime(2023, 7, 9, 22, 12, 15, 954, DateTimeKind.Local).AddTicks(2503), true, new Guid("a7d50e64-71bd-4c07-a22d-cbbacb7a944c"), 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "IsActive", "MasterId", "Status" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new Guid("00000000-0000-0000-0000-000000000000"), 0 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "IsActive", "MasterId", "Status" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new Guid("00000000-0000-0000-0000-000000000000"), 0 });
        }
    }
}
