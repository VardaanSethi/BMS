using BookMyShowWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookMyShowWebAPI.Services
{
    public interface IMovieService
    {
        public IEnumerable<Movie> GetMovies();
        public Movie GetMovie(int id);
    }
}
