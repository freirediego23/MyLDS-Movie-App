using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models
{
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
                        Title = "The Other Side of Heaven",
                        ReleaseDate = DateTime.Parse("2000-2-12"),
                        Genre = "Religious",
                        Rating = "PG",
                        Price = 11.99M,
                        Photo = "~/img/heaven3.png"
                    },

                    new Movie
                    {
                        Title = "The Other Side of Heaven 2 ",
                        ReleaseDate = DateTime.Parse("2005-9-15"),
                        Genre = "Religious",
                        Rating = "PG",
                        Price = 12.99M,
                        Photo = "~/img/rsz_heaven2.png"
                    },

                    new Movie
                    {
                        Title = "17 Miracles",
                        ReleaseDate = DateTime.Parse("2013-07-25"),
                        Genre = "Inspirational",
                        Rating = "PG",
                        Price = 10.50M,
                        Photo = "~/img/rsz_miracles.png"
                    },

                    new Movie
                    {
                        Title = "Book of Mormon Videos",
                        ReleaseDate = DateTime.Parse("2018-06-22"),
                        Genre = "Historical",
                        Rating = "G",
                        Price = 13.50M,
                        Photo = "~/img/rsz_mormonvid.png"
                    },

                    new Movie
                    {
                        Title = "John Rowe Moyle - Stonecutter",
                        ReleaseDate = DateTime.Parse("2010-2-25"),
                        Genre = "Inspirational",
                        Rating = "G",
                        Price = 12.50M,
                        Photo = "~/img/rsz_stone.png"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}