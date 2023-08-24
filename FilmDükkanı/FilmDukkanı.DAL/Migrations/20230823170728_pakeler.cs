using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FilmDukkanı.DAL.Migrations
{
    public partial class pakeler : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "MasterId" },
                values: new object[] { new DateTime(2023, 8, 23, 20, 7, 27, 673, DateTimeKind.Local).AddTicks(7016), new Guid("1f534375-df2a-48bc-9ce9-4d56f423676f") });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "MasterId" },
                values: new object[] { new DateTime(2023, 8, 23, 20, 7, 27, 677, DateTimeKind.Local).AddTicks(1292), new Guid("b6c855c7-d466-48a0-817b-91e56fcd8aae") });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "MasterId" },
                values: new object[] { new DateTime(2023, 8, 22, 19, 8, 38, 416, DateTimeKind.Local).AddTicks(625), new Guid("4f14b142-805f-4d8a-bc6a-15411dd5b4ed") });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "MasterId" },
                values: new object[] { new DateTime(2023, 8, 22, 19, 8, 38, 418, DateTimeKind.Local).AddTicks(8313), new Guid("3a5d45b0-6e26-4e5b-b6a9-52be5e860ea7") });
        }
    }
}
