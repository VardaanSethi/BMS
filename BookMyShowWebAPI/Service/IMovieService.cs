using BookMyShowWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookMyShowWebAPI.Service
{
    public interface IMovieService
    {
        public List<Movie> GetMovies();
        public Movie GetMovieById(int id);
    }
}
