using RestApi.Models;

namespace RestApi.Data
{
    public class CityDataStore
    {
        public List<CityDto> Cities { get; set; }
        public static CityDataStore Current { get; } = new CityDataStore();
        public CityDataStore() {
            Cities = new List<CityDto>()
        {
            new CityDto()
            {
                Id = 1,
                Name = "New York City",
                Description = "The one with that big park.",
                Interests = new List<InterestDto>()
                {
                    new InterestDto()
                    {
                        Id = 1,
                        Name = "Central Park",
                        Description = "A 102-story skyscraper located in Midtown Manhattan"
                    }
                }
            },
            new CityDto()
            {
                Id = 2,
                Name = "London",
                Description = "The one with the big clock.",
                Interests = new List<InterestDto>()
                {
                    new InterestDto()
                    {
                        Id = 2,
                        Name = "Big Ben",
                        Description = "A 96-meter tall clock tower at the north end of the Palace of Westminster"
                    },
                    new InterestDto()
                    {
                        Id = 3,
                        Name = "London Eye",
                        Description = "A giant Ferris wheel on the South Bank of the River Thames"
                    }
                }
            },
            new CityDto()
            {
                Id = 3,
                Name = "Paris",
                Description = "The one with the big tower.",
                Interests = new List<InterestDto>()
                {
                    new InterestDto()
                    {
                        Id = 4,
                        Name = "Eiffel Tower",
                        Description = "A wrought iron lattice tower on the Champ de Mars"
                    },
                    new InterestDto()
                    {
                        Id = 5,
                        Name = "Louvre Museum",
                        Description = "The world's largest art museum and a historic monument"
                    }
                }
            },
            new CityDto()
            {
                Id = 4,
                Name = "Tokyo",
                Description = "The one with the big fish market.",
                Interests = new List<InterestDto>()
                {
                    new InterestDto()
                    {
                        Id = 6,
                        Name = "Tsukiji Market",
                        Description = "A large wholesale market for fish, fruits and vegetables"
                    },
                    new InterestDto()
                    {
                        Id = 7,
                        Name = "Tokyo Skytree",
                        Description = "A broadcasting and observation tower in Sumida"
                    }
                }
            },
            new CityDto()
            {
                Id = 5,
                Name = "Sydney",
                Description = "The one with the big opera house.",
                Interests = new List<InterestDto>()
                {
                    new InterestDto()
                    {
                        Id = 8,
                        Name = "Sydney Opera House",
                        Description = "A multi-venue performing arts centre at Sydney Harbour"
                    },
                    new InterestDto()
                    {
                        Id = 9,
                        Name = "Sydney Harbour Bridge",
                        Description = "A steel arch bridge across Sydney Harbour"
                    }
                }
            },
            new CityDto()
            {
                Id = 6,
                Name = "Beijing",
                Description = "The one with the big wall.",
                Interests = new List<InterestDto>()
                {
                    new InterestDto()
                    {
                        Id = 10,
                        Name = "Great Wall of China",
                        Description = "A series of fortifications built along the historical border of China"
                    },
                    new InterestDto()
                    {
                        Id = 11,
                        Name = "Forbidden City",
                        Description = "A palace complex in central Beijing"
                    }
                }
            },
            new CityDto()
            {
                Id = 7,
                Name = "Rio de Janeiro",
                Description = "The one with the big statue.",
                Interests = new List<InterestDto>()
                {
                    new InterestDto()
                    {
                        Id = 12,
                        Name = "Christ the Redeemer",
                        Description = "An Art Deco statue of Jesus Christ atop Mount Corcovado"
                    },
                    new InterestDto()
                    {
                        Id = 13,
                        Name = "Copacabana Beach",
                        Description = "A famous beach in the south zone of Rio de Janeiro"
                    }
                }
            },
            new CityDto()
            {
                Id = 8,
                Name = "Cape Town",
                Description = "The one with the big mountain.",
                Interests = new List<InterestDto>()
                {
                    new InterestDto()
                    {
                        Id = 14,
                        Name = "Table Mountain",
                        Description = "A flat-topped mountain overlooking the city of Cape Town"
                    },
                    new InterestDto()
                    {
                        Id = 15,
                        Name = "Robben Island",
                        Description = "An island in Table Bay where Nelson Mandela was imprisoned"
                    }
                }
            },
            new CityDto()
            {
                Id = 9,
                Name = "Moscow",
                Description = "The one with the big square.",
                Interests = new List<InterestDto>()
                {
                    new InterestDto()
                    {
                        Id = 16,
                        Name = "Red Square",
                        Description = "A city square in the heart of Moscow"
                    },
                    new InterestDto()
                    {
                        Id = 17,
                        Name = "Saint Basil's Cathedral",
                        Description = "A colorful onion-domed church in Red Square"
                    }
                }
            },
            new CityDto()
            {
                Id = 10,
                Name = "Los Angeles",
                Description = "The one with the big sign.",
                Interests = new List<InterestDto>()
                {
                    new InterestDto()
                    {
                        Id = 18,
                        Name = "Hollywood Sign",
                        Description = "A landmark sign on Mount Lee"
                    },
                    new InterestDto()
                    {
                        Id = 19,
                        Name = "Universal Studios Hollywood",
                        Description = "A film studio and theme park in the San Fernando Valley"
                    }
                }
            }
        };
        }

    }
}
