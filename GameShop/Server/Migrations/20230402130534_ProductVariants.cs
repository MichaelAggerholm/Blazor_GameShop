using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GameShop.Server.Migrations
{
    /// <inheritdoc />
    public partial class ProductVariants : Migration
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
                    { new Guid("13564d3c-e2ef-46b3-9d78-3256e621e546"), "RPG", "rpg" },
                    { new Guid("643c4f63-9afd-43d5-80ad-a3204eeebdc5"), "Adventure", "adventure" },
                    { new Guid("9c9e8667-5d4e-4343-84ba-95acb554f778"), "Action", "action" }
                });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("206fefc2-2894-4c93-a28e-b119d9bc9a1a"), "PC" },
                    { new Guid("7ac2fb37-46aa-478b-90a2-4f6815353f79"), "Xbox" },
                    { new Guid("c8600275-087d-4c01-a5c9-9f7f59ad9ae5"), "Playstation" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImageUrl", "Title" },
                values: new object[,]
                {
                    { new Guid("75b1f8cf-0818-4c93-9648-71d4f6d9b53b"), new Guid("9c9e8667-5d4e-4343-84ba-95acb554f778"), "Grand Theft Auto V is a 2013 action-adventure game developed by Rockstar North and published by Rockstar Games. It is the seventh main entry in the Grand Theft Auto series, following 2008's Grand Theft Auto IV, and the fifteenth instalment overall. Set within the fictional state of San Andreas, based on Southern California, the single-player story follows three protagonists—retired bank robber Michael De Santa, street gangster Franklin Clinton, and drug dealer and gunrunner Trevor Philips—and their attempts to commit heists while under pressure from a corrupt government agency and powerful criminals.", "https://upload.wikimedia.org/wikipedia/en/a/a5/Grand_Theft_Auto_V.png?20221021000408", "Grand Theft Auto V" },
                    { new Guid("7cc52326-3da4-4af3-8a53-5769b42b92fb"), new Guid("13564d3c-e2ef-46b3-9d78-3256e621e546"), "World of Warcraft: The Burning Crusade is the first expansion set for the MMORPG World of Warcraft. It was released on January 16, 2007 at local midnight in Europe and North America, selling nearly 2.4 million copies on release day alone and making it, at the time, the fastest-selling PC game released at that point.", "https://upload.wikimedia.org/wikipedia/en/f/fc/World_of_Warcraft_The_Burning_Crusade.png?20220428192816", "World of Warcraft: The Burning Crusade" },
                    { new Guid("c5efb4c0-e13f-4219-bddf-cd27d0e488fe"), new Guid("643c4f63-9afd-43d5-80ad-a3204eeebdc5"), "Sid Meier's Civilization VI is a turn-based strategy 4X video game developed by Firaxis Games, published by 2K Games, and distributed by Take-Two Interactive. The mobile port was published by Aspyr Media. The latest entry into the Civilization series, it was released on Windows and macOS in October 2016, with later ports for Linux in February 2017, iOS in December 2017, Nintendo Switch in November 2018, PlayStation 4 and Xbox One in November 2019, and Android in 2020.", "https://upload.wikimedia.org/wikipedia/en/3/3b/Civilization_VI_cover_art.jpg?20171222223844", "Civilization VI" }
                });

            migrationBuilder.InsertData(
                table: "ProductVariants",
                columns: new[] { "ProductId", "ProductTypeId", "OriginalPrice", "Price" },
                values: new object[,]
                {
                    { new Guid("75b1f8cf-0818-4c93-9648-71d4f6d9b53b"), new Guid("c8600275-087d-4c01-a5c9-9f7f59ad9ae5"), 199m, 119m },
                    { new Guid("7cc52326-3da4-4af3-8a53-5769b42b92fb"), new Guid("206fefc2-2894-4c93-a28e-b119d9bc9a1a"), 169m, 99m },
                    { new Guid("c5efb4c0-e13f-4219-bddf-cd27d0e488fe"), new Guid("7ac2fb37-46aa-478b-90a2-4f6815353f79"), 0m, 99m }
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
