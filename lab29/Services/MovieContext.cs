using System;
using System.Collections.Generic;
using lab29.Services.DALModels;
using Microsoft.EntityFrameworkCore;

namespace lab29.Services
{
    public class MovieContext : DbContext
    {
        public MovieContext()
        {
            public DbSet<Movie> Movies { get; set; }
            public DbSet<Movie> Category { get; set; }
            public DbSet<Movie> Title { get; set; }

            public IEnumerable<Movie> GetMovies()
        {
            return Movies;
        }
            public IEnumerable<Movie> GetCategory()
        {
            return Category;
        }
            public IEnumerable<Movie> RandomMovie()
        {
            var rand = new Random();
            string index = rand.Next(List.Count);
            Console.WriteLine(List[index]);
        }
            public int RandomMoviePicks()
        {
            return Movies;
        }
            public Movie GetMovie(string movieCategory)
        {

        }

        }

    }
}
