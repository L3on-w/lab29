using System;
using lab29.Services;
using Microsoft.AspNetCore.Mvc;
using lab29.Services.DALModels;

namespace lab29.Controllers
{
    [ApiController]
    [Route("Controller")]
    public class MovieDataController : ControllerBase
    {
        private readonly IMovieContext _movieContext;
        public MovieDataController(IMovieContext movieContext)
        {
            _movieContext = movieContext;
        }

        [HttpGet]
        public IActionResult GetAllMovies()
        {
            return Ok(_movieContext.GetMovies());
        }

        [HttpGet]
        [Route("{movieCategory}")]
        public IActionResult GetMovie([FromRoute] string movieCategory)
        {
            var movie = _movieContext.GetMovie(movieCategory);
            if (movie != null)
            {
                return Ok(movie);
            }

            return NotFound($"No movies matching the provided category: {movieCategory} ");

        }


    }
}
