using BookMyShowWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookMyShowWebAPI.Services
{
    public interface IMovieService
    {
        IEnumerable<Movie> GetMovies();
        Movie GetMovie(int id);
    }
}
