using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TravelAPI.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Destinations",
                columns: table => new
                {
                    DestinationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CountryName = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: false),
                    CityName = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: false),
                    Review = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Destinations", x => x.DestinationId);
                });

            migrationBuilder.InsertData(
                table: "Destinations",
                columns: new[] { "DestinationId", "CityName", "CountryName", "Review" },
                values: new object[,]
                {
                    { 1, "Vancouver", "Canada", "I love this destination. There was lots of fun things to do. The landmarks alone are worth the travel!" },
                    { 2, "Mexico City", "Mexico", "Everything was so colorful and the mural art was amazing. Definitely worth the travel to see some of the Aztec ancient sites!" },
                    { 3, "Venezuela", "Italy", "The food is amazing and the ancient buildings and churches are beautiful! There is also lots of art and sculptures to be seen. Make sure you bring a few pairs of walking shoes!" },
                    { 4, "Song Khon", "Thailand", "The weather was nice and warm. The food not only was cheap but also really tasty. Its worth spending money on a good hotel!" },
                    { 5, "Auckland", "New Zeland", "You have to visit for yourself. The food was really good in general. The valleys were breathtaking..." }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Destinations");
        }
    }
}
