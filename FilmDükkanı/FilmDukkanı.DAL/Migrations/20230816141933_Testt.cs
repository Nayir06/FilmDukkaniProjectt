using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FilmDukkanı.DAL.Migrations
{
    public partial class Testt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Movies_MovieId",
                table: "Categories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categories",
                table: "Categories");

            migrationBuilder.RenameTable(
                name: "Categories",
                newName: "Category");

            migrationBuilder.RenameColumn(
                name: "MovieId",
                table: "Category",
                newName: "MoviesId");

            migrationBuilder.RenameIndex(
                name: "IX_Categories_MovieId",
                table: "Category",
                newName: "IX_Category_MoviesId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Category",
                table: "Category",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "MasterId" },
                values: new object[] { new DateTime(2023, 8, 16, 17, 19, 33, 35, DateTimeKind.Local).AddTicks(1933), new Guid("5c169843-7f67-4dfd-9b89-edc4064b701a") });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "MasterId" },
                values: new object[] { new DateTime(2023, 8, 16, 17, 19, 33, 38, DateTimeKind.Local).AddTicks(5142), new Guid("d9f5dcfa-6412-4c31-aaa1-5983ce56a63c") });

            migrationBuilder.AddForeignKey(
                name: "FK_Category_Movies_MoviesId",
                table: "Category",
                column: "MoviesId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Category_Movies_MoviesId",
                table: "Category");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Category",
                table: "Category");

            migrationBuilder.RenameTable(
                name: "Category",
                newName: "Categories");

            migrationBuilder.RenameColumn(
                name: "MoviesId",
                table: "Categories",
                newName: "MovieId");

            migrationBuilder.RenameIndex(
                name: "IX_Category_MoviesId",
                table: "Categories",
                newName: "IX_Categories_MovieId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categories",
                table: "Categories",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "MasterId" },
                values: new object[] { new DateTime(2023, 8, 8, 15, 15, 16, 895, DateTimeKind.Local).AddTicks(5629), new Guid("cb20b06b-af0c-46e8-a07b-c816c38863be") });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "MasterId" },
                values: new object[] { new DateTime(2023, 8, 8, 15, 15, 16, 897, DateTimeKind.Local).AddTicks(7871), new Guid("563c588a-6f01-4124-a9d7-445965d1cffa") });

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_Movies_MovieId",
                table: "Categories",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
