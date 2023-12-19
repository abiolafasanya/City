using Microsoft.EntityFrameworkCore;
using RestApi.Entities;
using RestApi.Models;

namespace RestApi.DbContexts
{
    public class CityDbContext : DbContext
    {
        public CityDbContext(DbContextOptions options) : base(options)
        {

        }

        // Db set
        public DbSet<City> Cities { get; set; } = null!;
        public DbSet<Interest> Interests { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<City>()
                .HasData(
                    new City("New York City")
                    {
                        Id = 1,
                        Description = "The one with that big park.",
                    },
                    new City("London") { Id = 2, Description = "The one with the big clock.", },
                    new City("Paris") { Id = 3, Description = "The one with the big tower.", },
                    new City("Tokyo")
                    {
                        Id = 4,
                        Description = "The one with the big fish market.",
                    },
                    new City("Sydney")
                    {
                        Id = 5,
                        Description = "The one with the big opera house.",
                    },
                    new City("Beijing") { Id = 6, Description = "The one with the big wall." },
                    new City("Rio de Janeiro")
                    {
                        Id = 7,
                        Description = "The one with the big statue.",
                    },
                    new City("Cape Town")
                    {
                        Id = 8,
                        Description = "The one with the big mountain.",
                    },
                    new City("Moscow") { Id = 9, Description = "The one with the big square.", },
                    new City("Los Angeles") { Id = 10, Description = "The one with the big sign.", }
                );

            modelBuilder
                .Entity<Interest>()
                .HasData(
                    new Interest("Central Park")
                    {
                        Id = 1,
                        CityId = 1,
                        Description = "A 102-story skyscraper located in Midtown Manhattan"
                    },
                    new Interest("Big Ben")
                    {
                        Id = 2,
                        CityId = 2,
                        Description =
                            "A 96-meter tall clock tower at the north end of the Palace of Westminster"
                    },
                    new Interest("London Eye")
                    {
                        Id = 3,
                        CityId = 2,
                        Description = "A giant Ferris wheel on the South Bank of the River Thames"
                    },
                    new Interest("Eiffel Tower")
                    {
                        Id = 4,
                        CityId = 3,
                        Description = "A wrought iron lattice tower on the Champ de Mars"
                    },
                    new Interest("Louvre Museum")
                    {
                        Id = 5,
                        CityId = 3,
                        Description = "The world's largest art museum and a historic monument"
                    },
                    new Interest("Tsukiji Market")
                    {
                        Id = 6,
                        CityId = 4,
                        Description = "A large wholesale market for fish, fruits, and vegetables"
                    },
                    new Interest("Tokyo Skytree")
                    {
                        Id = 7,
                        CityId = 4,
                        Description = "A broadcasting and observation tower in Sumida"
                    },
                    new Interest("Sydney Opera House")
                    {
                        Id = 8,
                        CityId = 5,
                        Description = "A multi-venue performing arts centre at Sydney Harbour"
                    },
                    new Interest("Sydney Harbour Bridge")
                    {
                        Id = 9,
                        CityId = 5,
                        Description = "A steel arch bridge across Sydney Harbour"
                    },
                    new Interest("Great Wall of China")
                    {
                        Id = 10,
                        CityId = 6,
                        Description =
                            "A series of fortifications built along the historical border of China"
                    },
                    new Interest("Forbidden City")
                    {
                        Id = 11,
                        CityId = 6,
                        Description = "A palace complex in central Beijing"
                    },
                    new Interest("Christ the Redeemer")
                    {
                        Id = 12,
                        CityId = 7,
                        Description = "An Art Deco statue of Jesus Christ atop Mount Corcovado"
                    },
                    new Interest("Copacabana Beach")
                    {
                        Id = 13,
                        CityId = 7,
                        Description = "A famous beach in the south zone of Rio de Janeiro"
                    },
                    new Interest("Table Mountain")
                    {
                        Id = 14,
                        CityId = 8,
                        Description = "A flat-topped mountain overlooking the city of Cape Town"
                    },
                    new Interest("Robben Island")
                    {
                        Id = 15,
                        CityId = 8,
                        Description = "An island in Table Bay where Nelson Mandela was imprisoned"
                    },
                    new Interest("Red Square")
                    {
                        Id = 16,
                        CityId = 9,
                        Description = "A city square in the heart of Moscow"
                    },
                    new Interest("Saint Basil's Cathedral")
                    {
                        Id = 17,
                        CityId = 9,
                        Description = "A colorful onion-domed church in Red Square"
                    },
                    new Interest("Hollywood Sign")
                    {
                        Id = 18,
                        CityId = 10,
                        Description = "A landmark sign on Mount Lee"
                    },
                    new Interest("Universal Studios Hollywood")
                    {
                        Id = 19,
                        CityId = 10,
                        Description = "A film studio and theme park in the San Fernando Valley"
                    }
                );

            base.OnModelCreating(modelBuilder);
        }
    }
}
