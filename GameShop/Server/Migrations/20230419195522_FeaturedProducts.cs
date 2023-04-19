using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GameShop.Server.Migrations
{
    /// <inheritdoc />
    public partial class FeaturedProducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("36733ae8-2b38-48a6-bade-927da9a07f9a"), new Guid("f7584ada-7190-40a8-93ec-1f83d6395d61") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("36733ae8-2b38-48a6-bade-927da9a07f9a"), new Guid("fb70495e-7f86-44db-827c-9741b83aec4d") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("87edb872-ce56-4ce1-a8e9-427e5d4cfb21"), new Guid("fb70495e-7f86-44db-827c-9741b83aec4d") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("bdaac88f-1e5d-4f6e-a6e2-1cd4b2e7d571"), new Guid("698f3c1c-e629-416d-a3ab-ebdc0aea3d2f") });

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: new Guid("698f3c1c-e629-416d-a3ab-ebdc0aea3d2f"));

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: new Guid("f7584ada-7190-40a8-93ec-1f83d6395d61"));

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: new Guid("fb70495e-7f86-44db-827c-9741b83aec4d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("36733ae8-2b38-48a6-bade-927da9a07f9a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("87edb872-ce56-4ce1-a8e9-427e5d4cfb21"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bdaac88f-1e5d-4f6e-a6e2-1cd4b2e7d571"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4436090c-b9f3-4ce6-bf01-4f8be9086bdf"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4b602f65-4926-441e-8eaf-1bd107ceab81"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fd13de0c-5da8-4e12-b421-9ef77802cf48"));

            migrationBuilder.AddColumn<bool>(
                name: "Featured",
                table: "Products",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name", "Url" },
                values: new object[,]
                {
                    { new Guid("1eccd9e4-a981-40fb-8263-5861966c7dad"), "Adventure", "adventure" },
                    { new Guid("873a81a1-fe37-4fcd-9b5e-d81ece037bd4"), "Action", "action" },
                    { new Guid("b51685c9-2764-4133-a3a3-d21a9017ad59"), "RPG", "rpg" }
                });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("3b57ed84-08fe-485e-89c1-33fe039a9270"), "PC" },
                    { new Guid("8806d898-a088-4eb6-a105-7f16ca8b29fb"), "Xbox" },
                    { new Guid("dc29f5d0-4daf-41e1-bddd-47ec34f87b66"), "Playstation" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "Featured", "ImageUrl", "Title" },
                values: new object[,]
                {
                    { new Guid("27a6b2a4-a3ed-4cfb-abfa-5c6f28f669b3"), new Guid("b51685c9-2764-4133-a3a3-d21a9017ad59"), "World of Warcraft: The Burning Crusade is the first expansion set for the MMORPG World of Warcraft. It was released on January 16, 2007 at local midnight in Europe and North America, selling nearly 2.4 million copies on release day alone and making it, at the time, the fastest-selling PC game released at that point.", true, "https://upload.wikimedia.org/wikipedia/en/f/fc/World_of_Warcraft_The_Burning_Crusade.png?20220428192816", "World of Warcraft: The Burning Crusade" },
                    { new Guid("98c1b146-52b5-4fa8-9267-3d8885d7ef63"), new Guid("873a81a1-fe37-4fcd-9b5e-d81ece037bd4"), "Grand Theft Auto V is a 2013 action-adventure game developed by Rockstar North and published by Rockstar Games. It is the seventh main entry in the Grand Theft Auto series, following 2008's Grand Theft Auto IV, and the fifteenth instalment overall. Set within the fictional state of San Andreas, based on Southern California, the single-player story follows three protagonists—retired bank robber Michael De Santa, street gangster Franklin Clinton, and drug dealer and gunrunner Trevor Philips—and their attempts to commit heists while under pressure from a corrupt government agency and powerful criminals.", false, "https://upload.wikimedia.org/wikipedia/en/a/a5/Grand_Theft_Auto_V.png?20221021000408", "Grand Theft Auto V" },
                    { new Guid("d5620668-2b0e-49be-ace7-9600e06bfb2d"), new Guid("1eccd9e4-a981-40fb-8263-5861966c7dad"), "Sid Meier's Civilization VI is a turn-based strategy 4X video game developed by Firaxis Games, published by 2K Games, and distributed by Take-Two Interactive. The mobile port was published by Aspyr Media. The latest entry into the Civilization series, it was released on Windows and macOS in October 2016, with later ports for Linux in February 2017, iOS in December 2017, Nintendo Switch in November 2018, PlayStation 4 and Xbox One in November 2019, and Android in 2020.", false, "https://upload.wikimedia.org/wikipedia/en/3/3b/Civilization_VI_cover_art.jpg?20171222223844", "Civilization VI" }
                });

            migrationBuilder.InsertData(
                table: "ProductVariants",
                columns: new[] { "ProductId", "ProductTypeId", "OriginalPrice", "Price" },
                values: new object[,]
                {
                    { new Guid("27a6b2a4-a3ed-4cfb-abfa-5c6f28f669b3"), new Guid("3b57ed84-08fe-485e-89c1-33fe039a9270"), 169m, 99m },
                    { new Guid("98c1b146-52b5-4fa8-9267-3d8885d7ef63"), new Guid("8806d898-a088-4eb6-a105-7f16ca8b29fb"), 219m, 139m },
                    { new Guid("98c1b146-52b5-4fa8-9267-3d8885d7ef63"), new Guid("dc29f5d0-4daf-41e1-bddd-47ec34f87b66"), 199m, 119m },
                    { new Guid("d5620668-2b0e-49be-ace7-9600e06bfb2d"), new Guid("8806d898-a088-4eb6-a105-7f16ca8b29fb"), 0m, 99m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("27a6b2a4-a3ed-4cfb-abfa-5c6f28f669b3"), new Guid("3b57ed84-08fe-485e-89c1-33fe039a9270") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("98c1b146-52b5-4fa8-9267-3d8885d7ef63"), new Guid("8806d898-a088-4eb6-a105-7f16ca8b29fb") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("98c1b146-52b5-4fa8-9267-3d8885d7ef63"), new Guid("dc29f5d0-4daf-41e1-bddd-47ec34f87b66") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("d5620668-2b0e-49be-ace7-9600e06bfb2d"), new Guid("8806d898-a088-4eb6-a105-7f16ca8b29fb") });

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: new Guid("3b57ed84-08fe-485e-89c1-33fe039a9270"));

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: new Guid("8806d898-a088-4eb6-a105-7f16ca8b29fb"));

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: new Guid("dc29f5d0-4daf-41e1-bddd-47ec34f87b66"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("27a6b2a4-a3ed-4cfb-abfa-5c6f28f669b3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("98c1b146-52b5-4fa8-9267-3d8885d7ef63"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d5620668-2b0e-49be-ace7-9600e06bfb2d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1eccd9e4-a981-40fb-8263-5861966c7dad"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("873a81a1-fe37-4fcd-9b5e-d81ece037bd4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b51685c9-2764-4133-a3a3-d21a9017ad59"));

            migrationBuilder.DropColumn(
                name: "Featured",
                table: "Products");

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
        }
    }
}
