using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BookMyShowWebAPI.Models;
using BookMyShowWebAPI.Service;

namespace BookMyShowWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly IMovieService movie;

        public MovieController(IMovieService movie)
        {
            this.movie = movie;
        }

        // GET: api/Movie
        [HttpGet]
        public IEnumerable<Movie> GetMovies()
        {
            return movie.GetMovies();
        }

        // GET: api/Movie/5
        [HttpGet("{id}")]
        public Movie GetMovie(int id)
        {
            return movie.GetMovieById(id);
        }
    }
}
