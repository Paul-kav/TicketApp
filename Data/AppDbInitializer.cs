using Microsoft.Extensions.DependencyInjection;
using TicketApp.Data.Enum;
using TicketApp.Models;

namespace TicketApp.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            //creating an application services scope
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                //create a reference to the appdbcontext file
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();
                context.Database.EnsureCreated();

                //Cinema
                if (!context.Cinemas.Any())
                {
                    context.Cinemas.AddRange(new List<Cinema>()
                   {
                       new Cinema()
                       {
                           FullName = "Cinema 1",
                           Description = "The goldies."
                       },
                       new Cinema()
                       {    FullName = "Cinema 2",
                            Description = "The theaters are open."

                       },
                       new Cinema()
                       {
                           FullName = "Cinema 3",
                           Description = "popcorn and soda."
                       },
                       new Cinema()
                       {
                           FullName = "Cinema 4",
                           Description = "Select what makes you happy."
                       },
                       new Cinema()
                       {
                           FullName = "Cinema 5",
                           Description = "The dollar."
                       },
                      
                   });
                    context.SaveChanges();
                }
                //Actors
                if(!context.Actors.Any())
                {
                    context.Actors.AddRange(new List<Actor>()
                    {
                        new Actor()
                        {
                            FullName = "Actor 1",
                            Biography = "The star of the west."
                        },
                        new Actor()
                        {
                            FullName = "Actor 2",
                            Biography = "The star of the east."
                        },
                        new Actor()
                        {
                            FullName = "Actor 3",
                            Biography = "The star of the mid-west."
                        },new Actor()
                        {
                            FullName = "Actor 4",
                            Biography = "The star of the south."
                        },new Actor()
                        {
                            FullName = "Actor 5",
                            Biography = "The star of the oceania."
                        }
                    });
                    context.SaveChanges();
                }
                //Producers
                if(!context.Producers.Any())
                {
                    context.Producers.AddRange(new List<Producer>()
                    {
                        new Producer()
                        {
                            FullName = "Producer 1",
                            Description = "The stud from rural China."

                        },
                        new Producer()
                        {
                            FullName = "Producer 2",
                            Description = "He rose from no where."

                        },
                        new Producer()
                        {
                            FullName = "Producer 3",
                            Description = "They have been with us even the one."

                        },
                        new Producer()
                        {
                            FullName = "Producer 4",
                            Description = "She has always been one of us."

                        },
                        new Producer()
                        {
                            FullName = "Producer 5",
                            Description = "He was always destined for film."

                        }
                    });
                    context.SaveChanges();
                }
                //Movies
                if(!context.Movies.Any())
                {
                    context.Movies.AddRange(new List<Movie>()
                    {
                        new Movie()
                        {
                            Name = "The Pirates",
                            Description = "The attack on the Indian ocean waters.",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-2),
                            CinemaId = 3,
                            ProducerId = 3,
                            Price = 14,
                            MovieCategory = MovieCategory.Documentary
                        },
                        new Movie()
                        {
                            Name = "The Russian Invasion.",
                            Description = "The Russian attack on Ukraine.",
                            StartDate = DateTime.Now.AddDays(3),
                            EndDate = DateTime.Now.AddDays(20),
                            CinemaId = 1,
                            ProducerId = 1,
                            Price = 40,
                            MovieCategory = MovieCategory.Documentary
                        },
                        new Movie()
                        {
                            Name = "Ghost",
                            Description = "The movie description",
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now.AddDays(3),
                            CinemaId = 4,
                            ProducerId = 4,
                            Price = 20,
                            MovieCategory = MovieCategory.Horror
                        },
                        new Movie()
                        {
                            Name = "Rust",
                            Description = "The rust movie description.",
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now.AddDays(7),
                            CinemaId = 1,
                            ProducerId = 2,
                            Price = 16,
                            MovieCategory = MovieCategory.Comedy
                        },
                        new Movie()
                        {
                            Name = "Law and Order",
                            Description = "The movie description",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-5),
                            CinemaId = 1,
                            ProducerId = 3,
                            Price = 67,
                            MovieCategory = MovieCategory.Action
                        },
                        new Movie()
                        {
                            Name = "Order in the house",
                            Description = "The movie description",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(10),
                            CinemaId = 1,
                            ProducerId = 5,
                            Price = 67,
                            MovieCategory = MovieCategory.Documentary
                        }

                    });
                    context.SaveChanges();
                };
                //Actors and Movies
                if(!context.Actors_Movies.Any())
                {
                    context.Actors_Movies.AddRange(new List<Actor_Movie>()
                    {
                        new Actor_Movie()
                        {
                            ActorId = 1,
                            MovieId = 1,
                        },
                        new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 1,
                        },
                        new Actor_Movie()
                        {
                            ActorId = 1,
                            MovieId = 2,
                        },
                        new Actor_Movie()
                        {
                            ActorId = 4,
                            MovieId = 2,
                        },
                        new Actor_Movie()
                        {
                            ActorId = 1,
                            MovieId = 3,
                        },
                        new Actor_Movie()
                        {
                            ActorId = 2,
                            MovieId = 3,
                        },
                        new Actor_Movie()
                        {
                            ActorId = 5,
                            MovieId = 3,
                        },
                        new Actor_Movie()
                        {
                            ActorId = 2,
                            MovieId = 4,
                        },
                        new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 4,
                        },
                        new Actor_Movie()
                        {
                            ActorId = 4,
                            MovieId = 4,
                        },
                        new Actor_Movie()
                        {
                            ActorId = 2,
                            MovieId = 5,
                        },
                        new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 5,
                        },
                        new Actor_Movie()
                        {
                            ActorId = 4,
                            MovieId = 5,
                        },
                        new Actor_Movie()
                        {
                            ActorId = 5,
                            MovieId = 5,
                        },
                        new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 6,
                        },
                        new Actor_Movie()
                        {
                            ActorId = 4,
                            MovieId = 6,
                        },
                        new Actor_Movie()
                        {
                            ActorId = 5,
                            MovieId = 6
                        }

                    });
                    context.SaveChanges();
                }
            }
        }
    }
}
