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
    public class ScreenService : IScreenService
    {
        private readonly IDbConnection db;
        public ScreenService(IConfiguration configuration)
        {
            this.db = new SqlConnection(configuration.GetConnectionString("DefaultConnection"));
        }
        public Screen GetScreenById(int id)
        {
            var sql = "SELECT * FROM Screens WHERE ScreenId = @id";
            var screen = db.Query<Screen>(sql, new { bookingId = id }).FirstOrDefault();
            return screen;
        }

        public List<Screen> GetScreens()
        {
            var sql = "SELECT * FROM Screens";
            var screenList = db.Query<Screen>(sql).ToList();
            return screenList;
        }

        public object GetSeatsByTheater(int theaterId)
        {
            var sql = "SELECT * FROM GetSeatsByTheater WHERE TheaterId = @theaterId";
            var seatsByTheater = db.Query<object>(sql, new { theaterId = theaterId }).FirstOrDefault();
            return seatsByTheater;
        }
    }
}
