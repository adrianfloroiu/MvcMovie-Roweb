using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new MvcMovieContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<MvcMovieContext>>()))
        {
            // Look for any movies.
            if (context.Movie.Any())
            {
                return;   // DB has been seeded
            }
            context.Movie.AddRange(
                new Movie
                {
                    Title = "When Harry Met Sally",
                    ReleaseDate = DateTime.Parse("1989-2-12"),
                    Genre = "Romantic Comedy",
                    Price = 7.99M
                },
                new Movie
                {
                    Title = "Ghostbusters ",
                    ReleaseDate = DateTime.Parse("1984-3-13"),
                    Genre = "Comedy",
                    Price = 8.99M
                },
                new Movie
                {
                    Title = "Ghostbusters 2",
                    ReleaseDate = DateTime.Parse("1986-2-23"),
                    Genre = "Comedy",
                    Price = 9.99M
                },
                new Movie
                {
                    Title = "Rio Bravo",
                    ReleaseDate = DateTime.Parse("1959-4-15"),
                    Genre = "Western",
                    Price = 3.99M
                }
            );

            // Video Games Data

            if (context.VideoGame.Any())
            {
                return;
            }
            context.VideoGame.AddRange(
                new VideoGame
                {
                    Title = "Grand Theft Auto V",
                    Developer = "Rockstar Games",
                    ReleaseDate = DateTime.Parse("2013-9-17"),
                    Genre = "Open-World",
                    Platform = "PlayStation 3/4/5, Xbox 360/One, PC"
                },
                new VideoGame
                {
                    Title = "League of Legends",
                    Developer = "Riot Games",
                    ReleaseDate = DateTime.Parse("2009-10-27"),
                    Genre = "MOBA",
                    Platform = "Microsoft Windows, macOS"
                },
                new VideoGame
                {
                    Title = "The Outlast Trials",
                    Developer = "Red Barrels",
                    ReleaseDate = DateTime.Parse("2023-5-18"),
                    Genre = "Horror",
                    Platform = "Microsoft Windows"
                }
            );

            context.SaveChanges();
        }
    }
}