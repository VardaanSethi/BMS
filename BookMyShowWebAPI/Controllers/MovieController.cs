using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BookMyShowWebAPI.Models;
using BookMyShowWebAPI.Services;

namespace BookMyShowWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly IMovieService Movie;

        public MovieController(IMovieService movie)
        {
            this.Movie = movie;
        }

        // GET: api/Movie
        [HttpGet]
        public IEnumerable<Movie> GetMovies()
        {
            return Movie.GetMovies();
        }

        // GET: api/Movie/5
        [HttpGet("{id}")]
        public Movie GetMovie(int id)
        {
            return Movie.GetMovie(id);
        }
    }
}
