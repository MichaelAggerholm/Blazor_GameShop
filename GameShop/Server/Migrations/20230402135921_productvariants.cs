using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GameShop.Server.Migrations
{
    /// <inheritdoc />
    public partial class productvariants : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Url = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    ImageUrl = table.Column<string>(type: "TEXT", nullable: false),
                    CategoryId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductVariants",
                columns: table => new
                {
                    ProductId = table.Column<Guid>(type: "TEXT", nullable: false),
                    ProductTypeId = table.Column<Guid>(type: "TEXT", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OriginalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductVariants", x => new { x.ProductId, x.ProductTypeId });
                    table.ForeignKey(
                        name: "FK_ProductVariants_ProductTypes_ProductTypeId",
                        column: x => x.ProductTypeId,
                        principalTable: "ProductTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductVariants_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name", "Url" },
                values: new object[,]
                {
                    { new Guid("4436090c-b9f3-4ce6-bf01-4f8be9086bdf"), "Action", "action" },
                    { new Guid("4b602f65-4926-441e-8eaf-1bd107ceab81"), "RPG", "rpg" },
                    { new Guid("fd13de0c-5da8-4e12-b421-9ef77802cf48"), "Adventure", "adventure" }
                });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("698f3c1c-e629-416d-a3ab-ebdc0aea3d2f"), "PC" },
                    { new Guid("f7584ada-7190-40a8-93ec-1f83d6395d61"), "Playstation" },
                    { new Guid("fb70495e-7f86-44db-827c-9741b83aec4d"), "Xbox" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImageUrl", "Title" },
                values: new object[,]
                {
                    { new Guid("36733ae8-2b38-48a6-bade-927da9a07f9a"), new Guid("4436090c-b9f3-4ce6-bf01-4f8be9086bdf"), "Grand Theft Auto V is a 2013 action-adventure game developed by Rockstar North and published by Rockstar Games. It is the seventh main entry in the Grand Theft Auto series, following 2008's Grand Theft Auto IV, and the fifteenth instalment overall. Set within the fictional state of San Andreas, based on Southern California, the single-player story follows three protagonists—retired bank robber Michael De Santa, street gangster Franklin Clinton, and drug dealer and gunrunner Trevor Philips—and their attempts to commit heists while under pressure from a corrupt government agency and powerful criminals.", "https://upload.wikimedia.org/wikipedia/en/a/a5/Grand_Theft_Auto_V.png?20221021000408", "Grand Theft Auto V" },
                    { new Guid("87edb872-ce56-4ce1-a8e9-427e5d4cfb21"), new Guid("fd13de0c-5da8-4e12-b421-9ef77802cf48"), "Sid Meier's Civilization VI is a turn-based strategy 4X video game developed by Firaxis Games, published by 2K Games, and distributed by Take-Two Interactive. The mobile port was published by Aspyr Media. The latest entry into the Civilization series, it was released on Windows and macOS in October 2016, with later ports for Linux in February 2017, iOS in December 2017, Nintendo Switch in November 2018, PlayStation 4 and Xbox One in November 2019, and Android in 2020.", "https://upload.wikimedia.org/wikipedia/en/3/3b/Civilization_VI_cover_art.jpg?20171222223844", "Civilization VI" },
                    { new Guid("bdaac88f-1e5d-4f6e-a6e2-1cd4b2e7d571"), new Guid("4b602f65-4926-441e-8eaf-1bd107ceab81"), "World of Warcraft: The Burning Crusade is the first expansion set for the MMORPG World of Warcraft. It was released on January 16, 2007 at local midnight in Europe and North America, selling nearly 2.4 million copies on release day alone and making it, at the time, the fastest-selling PC game released at that point.", "https://upload.wikimedia.org/wikipedia/en/f/fc/World_of_Warcraft_The_Burning_Crusade.png?20220428192816", "World of Warcraft: The Burning Crusade" }
                });

            migrationBuilder.InsertData(
                table: "ProductVariants",
                columns: new[] { "ProductId", "ProductTypeId", "OriginalPrice", "Price" },
                values: new object[,]
                {
                    { new Guid("36733ae8-2b38-48a6-bade-927da9a07f9a"), new Guid("f7584ada-7190-40a8-93ec-1f83d6395d61"), 199m, 119m },
                    { new Guid("36733ae8-2b38-48a6-bade-927da9a07f9a"), new Guid("fb70495e-7f86-44db-827c-9741b83aec4d"), 219m, 139m },
                    { new Guid("87edb872-ce56-4ce1-a8e9-427e5d4cfb21"), new Guid("fb70495e-7f86-44db-827c-9741b83aec4d"), 0m, 99m },
                    { new Guid("bdaac88f-1e5d-4f6e-a6e2-1cd4b2e7d571"), new Guid("698f3c1c-e629-416d-a3ab-ebdc0aea3d2f"), 169m, 99m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductVariants_ProductTypeId",
                table: "ProductVariants",
                column: "ProductTypeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductVariants");

            migrationBuilder.DropTable(
                name: "ProductTypes");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
