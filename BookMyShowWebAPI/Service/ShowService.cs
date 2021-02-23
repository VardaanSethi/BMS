using BookMyShowWebAPI.Models;
using Dapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace BookMyShowWebAPI.Service
{
    public class ShowService : IShowService
    {
        private readonly IDbConnection db;
        public ShowService(IConfiguration configuration)
        {
            this.db = new SqlConnection(configuration.GetConnectionString("DefaultConnection"));
        }
        public List<object> ShowsListByTheater (int theaterId, int movieId)
        {
            var sql = "SELECT * FROM GetShowsByTheater WHERE TheaterId = @theaterId AND MovieId = @movieId";
            var showListByTheater = db.Query<object>(sql, new { theaterId = theaterId, movieId = movieId }).ToList();
            return showListByTheater;
        }
        public Show GetShowById(int id)
        {
            var sql = "SELECT * FROM Shows WHERE ShowId = @id";
            var show = db.Query<Show>(sql, new { bookingId = id }).FirstOrDefault();
            return show;
        }
        public List<Show> GetShows()
        {
            var sql = "SELECT * FROM Shows";
            var showList = db.Query<Show>(sql).ToList();
            return showList;
        }
    }
}