using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GameShop.Server.Migrations
{
    /// <inheritdoc />
    public partial class productMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    ImageUrl = table.Column<string>(type: "TEXT", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[,]
                {
                    { new Guid("4f0603e8-5bb0-4128-9ea7-c7381b9f0033"), "World of Warcraft: The Burning Crusade is the first expansion set for the MMORPG World of Warcraft. It was released on January 16, 2007 at local midnight in Europe and North America, selling nearly 2.4 million copies on release day alone and making it, at the time, the fastest-selling PC game released at that point.", "https://upload.wikimedia.org/wikipedia/en/f/fc/World_of_Warcraft_The_Burning_Crusade.png?20220428192816", 99m, "World of Warcraft: The Burning Crusade" },
                    { new Guid("58ab554d-8fac-48ae-928b-a1032e151ee2"), "Sid Meier's Civilization VI is a turn-based strategy 4X video game developed by Firaxis Games, published by 2K Games, and distributed by Take-Two Interactive. The mobile port was published by Aspyr Media. The latest entry into the Civilization series, it was released on Windows and macOS in October 2016, with later ports for Linux in February 2017, iOS in December 2017, Nintendo Switch in November 2018, PlayStation 4 and Xbox One in November 2019, and Android in 2020.", "https://upload.wikimedia.org/wikipedia/en/3/3b/Civilization_VI_cover_art.jpg?20171222223844", 149m, "Civilization VI" },
                    { new Guid("6f640cb8-9b61-4b23-a339-040be7ae22d2"), "Grand Theft Auto V is a 2013 action-adventure game developed by Rockstar North and published by Rockstar Games. It is the seventh main entry in the Grand Theft Auto series, following 2008's Grand Theft Auto IV, and the fifteenth instalment overall. Set within the fictional state of San Andreas, based on Southern California, the single-player story follows three protagonists—retired bank robber Michael De Santa, street gangster Franklin Clinton, and drug dealer and gunrunner Trevor Philips—and their attempts to commit heists while under pressure from a corrupt government agency and powerful criminals.", "https://upload.wikimedia.org/wikipedia/en/a/a5/Grand_Theft_Auto_V.png?20221021000408", 99m, "Grand Theft Auto V" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
