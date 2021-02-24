using BookMyShowWebAPI.Models;
using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace BookMyShowWebAPI.Services
{
    public class MovieService : IMovieService
    {
        private readonly IDbConnection db;
        public MovieService(IConfiguration configuration)
        {
            this.db = new SqlConnection(configuration.GetConnectionString("DefaultConnection"));
        }
        public Movie GetMovie(int id)
        {
            return db.Query<Movie>("SELECT * FROM Movies WHERE Id = @id", new { id = id }).SingleOrDefault();
        }

        public IEnumerable<Movie> GetMovies()
        {
            return db.Query<Movie>("SELECT * FROM Movies");
        }
    }
}
