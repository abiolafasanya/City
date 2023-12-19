using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RestApi.Migrations
{
    /// <inheritdoc />
    public partial class DataSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "The one with that big park.", "New York City" },
                    { 2, "The one with the big clock.", "London" },
                    { 3, "The one with the big tower.", "Paris" },
                    { 4, "The one with the big fish market.", "Tokyo" },
                    { 5, "The one with the big opera house.", "Sydney" },
                    { 6, "The one with the big wall.", "Beijing" },
                    { 7, "The one with the big statue.", "Rio de Janeiro" },
                    { 8, "The one with the big mountain.", "Cape Town" },
                    { 9, "The one with the big square.", "Moscow" },
                    { 10, "The one with the big sign.", "Los Angeles" }
                });

            migrationBuilder.InsertData(
                table: "Interests",
                columns: new[] { "Id", "CityId", "Description", "Name" },
                values: new object[,]
                {
                    { 1, 1, "A 102-story skyscraper located in Midtown Manhattan", "Central Park" },
                    { 2, 2, "A 96-meter tall clock tower at the north end of the Palace of Westminster", "Big Ben" },
                    { 3, 2, "A giant Ferris wheel on the South Bank of the River Thames", "London Eye" },
                    { 4, 3, "A wrought iron lattice tower on the Champ de Mars", "Eiffel Tower" },
                    { 5, 3, "The world's largest art museum and a historic monument", "Louvre Museum" },
                    { 6, 4, "A large wholesale market for fish, fruits, and vegetables", "Tsukiji Market" },
                    { 7, 4, "A broadcasting and observation tower in Sumida", "Tokyo Skytree" },
                    { 8, 5, "A multi-venue performing arts centre at Sydney Harbour", "Sydney Opera House" },
                    { 9, 5, "A steel arch bridge across Sydney Harbour", "Sydney Harbour Bridge" },
                    { 10, 6, "A series of fortifications built along the historical border of China", "Great Wall of China" },
                    { 11, 6, "A palace complex in central Beijing", "Forbidden City" },
                    { 12, 7, "An Art Deco statue of Jesus Christ atop Mount Corcovado", "Christ the Redeemer" },
                    { 13, 7, "A famous beach in the south zone of Rio de Janeiro", "Copacabana Beach" },
                    { 14, 8, "A flat-topped mountain overlooking the city of Cape Town", "Table Mountain" },
                    { 15, 8, "An island in Table Bay where Nelson Mandela was imprisoned", "Robben Island" },
                    { 16, 9, "A city square in the heart of Moscow", "Red Square" },
                    { 17, 9, "A colorful onion-domed church in Red Square", "Saint Basil's Cathedral" },
                    { 18, 10, "A landmark sign on Mount Lee", "Hollywood Sign" },
                    { 19, 10, "A film studio and theme park in the San Fernando Valley", "Universal Studios Hollywood" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 10);
        }
    }
}
