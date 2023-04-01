using Microsoft.EntityFrameworkCore;

namespace GameShop.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var RpgCategory = new Category
            {
                Id = Guid.NewGuid(),
                Name = "RPG",
                Url = "rpg"
            };

            var ActionCategory = new Category
            {
                Id = Guid.NewGuid(),
                Name = "Action",
                Url = "action"
            };

            var AdventureCategory = new Category
            {
                Id = Guid.NewGuid(),
                Name = "Adventure",
                Url = "adventure"
            };

            modelBuilder.Entity<Category>().HasData(
                ActionCategory,
                AdventureCategory,
                RpgCategory
            );

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = Guid.NewGuid(),
                    Title = "World of Warcraft: The Burning Crusade",
                    Description = "World of Warcraft: The Burning Crusade is the first expansion set for the MMORPG World of Warcraft. It was released on January 16, 2007 at local midnight in Europe and North America, selling nearly 2.4 million copies on release day alone and making it, at the time, the fastest-selling PC game released at that point.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/en/f/fc/World_of_Warcraft_The_Burning_Crusade.png?20220428192816",
                    Price = 99,
                    CategoryId = RpgCategory.Id
                },
                new Product
                {
                    Id = Guid.NewGuid(),
                    Title = "Civilization VI",
                    Description = "Sid Meier's Civilization VI is a turn-based strategy 4X video game developed by Firaxis Games, published by 2K Games, and distributed by Take-Two Interactive. The mobile port was published by Aspyr Media. The latest entry into the Civilization series, it was released on Windows and macOS in October 2016, with later ports for Linux in February 2017, iOS in December 2017, Nintendo Switch in November 2018, PlayStation 4 and Xbox One in November 2019, and Android in 2020.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/en/3/3b/Civilization_VI_cover_art.jpg?20171222223844",
                    Price = 149,
                    CategoryId = AdventureCategory.Id
                },
                new Product
                {
                    Id = Guid.NewGuid(),
                    Title = "Grand Theft Auto V",
                    Description = "Grand Theft Auto V is a 2013 action-adventure game developed by Rockstar North and published by Rockstar Games. It is the seventh main entry in the Grand Theft Auto series, following 2008's Grand Theft Auto IV, and the fifteenth instalment overall. Set within the fictional state of San Andreas, based on Southern California, the single-player story follows three protagonists—retired bank robber Michael De Santa, street gangster Franklin Clinton, and drug dealer and gunrunner Trevor Philips—and their attempts to commit heists while under pressure from a corrupt government agency and powerful criminals.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/en/a/a5/Grand_Theft_Auto_V.png?20221021000408",
                    Price = 99,
                    CategoryId = ActionCategory.Id
                }
            );
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}