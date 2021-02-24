using BookMyShowWebAPI.Models;
using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace BookMyShowWebAPI.Services
{
    public class ShowService : IShowService
    {
        private readonly IDbConnection db;
        public ShowService(IConfiguration configuration)
        {
            this.db = new SqlConnection(configuration.GetConnectionString("DefaultConnection"));
        }
        public IEnumerable<object> ShowsListByTheater (int theaterId, int movieId)
        {
            return db.Query<object>("SELECT * FROM GetShowsByTheater WHERE TheaterId = @theaterId AND MovieId = @movieId", new { theaterId = theaterId, movieId = movieId });
        }
        public Show GetShow(int id)
        {
            return db.Query<Show>("SELECT * FROM Shows WHERE Id = @id", new { id = id }).SingleOrDefault();
        }
        public IEnumerable<Show> GetShows()
        {
            return db.Query<Show>("SELECT * FROM Shows");
        }
    }
}