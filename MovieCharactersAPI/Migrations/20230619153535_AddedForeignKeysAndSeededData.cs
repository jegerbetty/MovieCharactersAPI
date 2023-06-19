using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MovieCharactersAPI.Migrations
{
    public partial class AddedForeignKeysAndSeededData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FranchiseId1",
                table: "Movies",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "CharacterMovie",
                columns: table => new
                {
                    MovieCharactersId = table.Column<int>(type: "int", nullable: false),
                    MovieCharactersId1 = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterMovie", x => new { x.MovieCharactersId, x.MovieCharactersId1 });
                    table.ForeignKey(
                        name: "FK_CharacterMovie_Characters_MovieCharactersId",
                        column: x => x.MovieCharactersId,
                        principalTable: "Characters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterMovie_Movies_MovieCharactersId1",
                        column: x => x.MovieCharactersId1,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Characters",
                columns: new[] { "Id", "Alias", "CharacterPicture", "FullName", "Gender" },
                values: new object[,]
                {
                    { 1, "The White Wizard", "https://static.wikia.nocookie.net/lotr/images/e/e7/Gandalf_the_Grey.jpg/revision/latest?cb=20121110131754", "Gandalf the Grey", "Male" },
                    { 2, "The Chosen One", "https://periskop.no/wp-content/uploads/2021/02/Harry-Potter-med-tryllestaven.jpg", "Harry Potter", "Male" },
                    { 3, "He Who Shall Not Be Named", "https://upload.wikimedia.org/wikipedia/en/a/a3/Lordvoldemort.jpg", "Voldemort", "Male" }
                });

            migrationBuilder.InsertData(
                table: "Franchises",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "The Lord of the Rings is the saga of a group of sometimes reluctant heroes who set forth to save their world from consummate evil. Its many worlds and creatures were drawn from Tolkien's extensive knowledge of philology and folklore.", "Lord of the Rings" },
                    { 2, "The films chronicle the lives of a young wizard, Harry Potter, and his friends Hermione Granger and Ron Weasley, all of whom are students at Hogwarts School of Witchcraft and Wizardry.", "Harry Potter" }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Director", "FranchiseId1", "MovieGenre", "MoviePicture", "MovieTitle", "MovieTrailer", "ReleaseYear" },
                values: new object[,]
                {
                    { 1, "Peter Jackson", null, "Fantasy", "https://m.media-amazon.com/images/I/51ILUdMuieL._AC_UF1000,1000_QL80_.jpg", "The Fellowship of the Ring", "https://www.youtube.com/watch?v=V75dMMIW2B4&ab_channel=Movieclips", 2001 },
                    { 2, "Peter Jackson", null, "Fantasy", "https://m.media-amazon.com/images/I/91+ni21hctL._UF1000,1000_QL80_.jpg", "The Return of the King", "https://www.youtube.com/watch?v=y2rYRu8UW8M&ab_channel=RottenTomatoesClassicTrailers", 2003 },
                    { 3, "Mike Newell", null, "Magical Adventure", "https://upload.wikimedia.org/wikipedia/en/c/c9/Harry_Potter_and_the_Goblet_of_Fire_Poster.jpg", "Harry Potter and the Goblet of Fire", "https://www.youtube.com/watch?v=3EGojp4Hh6I&ab_channel=RottenTomatoesClassicTrailers", 2005 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Movies_FranchiseId1",
                table: "Movies",
                column: "FranchiseId1");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterMovie_MovieCharactersId1",
                table: "CharacterMovie",
                column: "MovieCharactersId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Franchises_FranchiseId1",
                table: "Movies",
                column: "FranchiseId1",
                principalTable: "Franchises",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Franchises_FranchiseId1",
                table: "Movies");

            migrationBuilder.DropTable(
                name: "CharacterMovie");

            migrationBuilder.DropIndex(
                name: "IX_Movies_FranchiseId1",
                table: "Movies");

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Franchises",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Franchises",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "FranchiseId1",
                table: "Movies");
        }
    }
}
