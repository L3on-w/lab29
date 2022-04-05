using System;
using System.Collections.Generic;
using lab29.Services.DALModels;

namespace lab29.Services
{
    public interface IMovieContext : IGetMovies, IGetMovieCategories, IGetMovieTitles, IGetMovie
    {
    }

    public interface IGetMovies
    {
        IEnumerable<Movie> GetMovies();
    }

    public interface IGetMovieCategories
    {
        IEnumerable<Movie> GetCategories();
    }

    public interface IGetMovieTitles
    {
        IEnumerable<Movie> GetMovieTitle();
    }

    public interface IGetMovie
    {
        IEnumerable<Movie> GetMovie();
    }
}
