using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FilmDukkanı.DAL.Migrations
{
    public partial class contexte : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Category_Movies_MoviesId",
                table: "Category");

            migrationBuilder.DropIndex(
                name: "IX_Category_MoviesId",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "MoviesId",
                table: "Category");

            migrationBuilder.AddColumn<int>(
                name: "ActorId",
                table: "Movies",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ActorId",
                table: "Category",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MovieId",
                table: "Category",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Actors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MasterId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Actors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Directors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DirectorName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MasterId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Directors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CategoryDirector",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    DirectorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryDirector", x => new { x.CategoryId, x.DirectorId });
                    table.ForeignKey(
                        name: "FK_CategoryDirector_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoryDirector_Directors_DirectorId",
                        column: x => x.DirectorId,
                        principalTable: "Directors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "MasterId" },
                values: new object[] { new DateTime(2023, 8, 16, 17, 59, 33, 962, DateTimeKind.Local).AddTicks(9213), new Guid("3a6b3ac8-7c43-4a92-ba15-236167163011") });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "MasterId" },
                values: new object[] { new DateTime(2023, 8, 16, 17, 59, 33, 966, DateTimeKind.Local).AddTicks(43), new Guid("cd291cca-10cf-4f6a-9984-607d0840ef18") });

            migrationBuilder.CreateIndex(
                name: "IX_Movies_ActorId",
                table: "Movies",
                column: "ActorId");

            migrationBuilder.CreateIndex(
                name: "IX_Category_ActorId",
                table: "Category",
                column: "ActorId");

            migrationBuilder.CreateIndex(
                name: "IX_Category_MovieId",
                table: "Category",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryDirector_DirectorId",
                table: "CategoryDirector",
                column: "DirectorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Category_Actors_ActorId",
                table: "Category",
                column: "ActorId",
                principalTable: "Actors",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Category_Movies_MovieId",
                table: "Category",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Actors_ActorId",
                table: "Movies",
                column: "ActorId",
                principalTable: "Actors",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Category_Actors_ActorId",
                table: "Category");

            migrationBuilder.DropForeignKey(
                name: "FK_Category_Movies_MovieId",
                table: "Category");

            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Actors_ActorId",
                table: "Movies");

            migrationBuilder.DropTable(
                name: "Actors");

            migrationBuilder.DropTable(
                name: "CategoryDirector");

            migrationBuilder.DropTable(
                name: "Directors");

            migrationBuilder.DropIndex(
                name: "IX_Movies_ActorId",
                table: "Movies");

            migrationBuilder.DropIndex(
                name: "IX_Category_ActorId",
                table: "Category");

            migrationBuilder.DropIndex(
                name: "IX_Category_MovieId",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "ActorId",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "ActorId",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "MovieId",
                table: "Category");

            migrationBuilder.AddColumn<int>(
                name: "MoviesId",
                table: "Category",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.CreateIndex(
                name: "IX_Category_MoviesId",
                table: "Category",
                column: "MoviesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Category_Movies_MoviesId",
                table: "Category",
                column: "MoviesId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
