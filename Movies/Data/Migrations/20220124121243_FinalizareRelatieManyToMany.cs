using Microsoft.EntityFrameworkCore.Migrations;

namespace Movies.Data.Migrations
{
    public partial class FinalizareRelatieManyToMany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MovieComment_Movies_MovieId",
                table: "MovieComment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MovieComment",
                table: "MovieComment");

            migrationBuilder.DropColumn(
                name: "Genre",
                table: "Movies");

            migrationBuilder.RenameTable(
                name: "MovieComment",
                newName: "MovieComments");

            migrationBuilder.RenameIndex(
                name: "IX_MovieComment_MovieId",
                table: "MovieComments",
                newName: "IX_MovieComments_MovieId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MovieComments",
                table: "MovieComments",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumeGen = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MovieGenres",
                columns: table => new
                {
                    MovieId = table.Column<int>(type: "int", nullable: false),
                    GenreId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieGenres", x => new { x.MovieId, x.GenreId });
                    table.ForeignKey(
                        name: "FK_MovieGenres_Genres_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MovieGenres_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MovieGenres_GenreId",
                table: "MovieGenres",
                column: "GenreId");

            migrationBuilder.AddForeignKey(
                name: "FK_MovieComments_Movies_MovieId",
                table: "MovieComments",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MovieComments_Movies_MovieId",
                table: "MovieComments");

            migrationBuilder.DropTable(
                name: "MovieGenres");

            migrationBuilder.DropTable(
                name: "Genres");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MovieComments",
                table: "MovieComments");

            migrationBuilder.RenameTable(
                name: "MovieComments",
                newName: "MovieComment");

            migrationBuilder.RenameIndex(
                name: "IX_MovieComments_MovieId",
                table: "MovieComment",
                newName: "IX_MovieComment_MovieId");

            migrationBuilder.AddColumn<string>(
                name: "Genre",
                table: "Movies",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_MovieComment",
                table: "MovieComment",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MovieComment_Movies_MovieId",
                table: "MovieComment",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
