using BookMyShowWebAPI.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using Microsoft.Data.SqlClient;
using System.Data;

namespace BookMyShowWebAPI.Service
{
    public class TheaterService : ITheaterService
    {
        private readonly IDbConnection db;
        public TheaterService(IConfiguration configuration)
        {
            this.db = new SqlConnection(configuration.GetConnectionString("DefaultConnection"));
        }
        public Theater GetTheaterById(int id)
        {
            var sql = "SELECT * FROM Theaters WHERE TheaterId = @id";
            var theater = db.Query<Theater>(sql, new { bookingId = id }).FirstOrDefault();
            return theater;
        }

        public List<Theater> GetTheaters()
        {
            var sql = "SELECT * FROM Theaters";
            var theaterList = db.Query<Theater>(sql).ToList();
            return theaterList;
        }
    }
}
