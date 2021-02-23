using BookMyShowWebAPI.Models;
using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace BookMyShowWebAPI.Service
{
    public class MovieService : IMovieService
    {
        private readonly IDbConnection db;
        public MovieService(IConfiguration configuration)
        {
            this.db = new SqlConnection(configuration.GetConnectionString("DefaultConnection"));
        }
        public Movie GetMovieById(int id)
        {
            var sql = "SELECT * FROM Movies WHERE MovieId = @id";
            var movie = db.Query<Movie>(sql, new { id = id }).FirstOrDefault();
            return movie;
        }

        public List<Movie> GetMovies()
        {
            var sql = "SELECT * FROM Movies";
            var movieList = db.Query<Movie>(sql).ToList();
            return movieList;
        }
    }
}
