using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloWorldMVC.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context= new HelloWorldMVCContext
                (serviceProvider.GetRequiredService<DbContextOptions<HelloWorldMVCContext>>()))
            {
                //look for any movies
                if (context.Movie.Any())
                {
                    return; //DB has been seeded
                }
                context.Movie.AddRange(
                   new Movie
                   {
                       title = "Dhamaal",
                       ReleaseDate = DateTime.Parse("07-09-2007"),
                       genre = "Comedy",
                       Price = 6.87M
                   },
                    new Movie
                    {
                        title = "Taaren Zameen Par",
                        ReleaseDate = DateTime.Parse("21-12-2007"),
                        genre = "Drama",
                        Price = 7.99M
                    },
                    
                    new Movie
                    {
                        title = "Bhaag Milkha Bhaag",
                        ReleaseDate = DateTime.Parse("11-07-2013"),
                        genre = "Biography",
                        Price = 7.90M
                    },
                    new Movie
                    {
                        title = "Bang Bang",
                        ReleaseDate = DateTime.Parse("02-10-2014"),
                        genre = "Action Drama",
                        Price = 8.99M
                    },
                    new Movie
                    {
                        title = "Andhadhun",
                        ReleaseDate = DateTime.Parse("05-10-2018"),
                        genre = "Suspense Thriller",
                        Price = 8.34M
                    }
                    );
                context.SaveChanges();
            }
        }
    }
}
