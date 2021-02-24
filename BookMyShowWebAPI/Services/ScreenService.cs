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
    public class ScreenService : IScreenService
    {
        private readonly IDbConnection db;
        public ScreenService(IConfiguration configuration)
        {
            this.db = new SqlConnection(configuration.GetConnectionString("DefaultConnection"));
        }
        public Screen GetScreen(int id)
        {
            return db.Query<Screen>("SELECT * FROM Screens WHERE Id = @id", new { id = id }).SingleOrDefault();
        }

        public IEnumerable<Screen> GetScreens()
        {
            return db.Query<Screen>("SELECT * FROM Screens");
        }

        public object GetSeatsByTheater(int theaterId)
        {
            var sql = "SELECT NoOfSeats FROM Screens WHERE Id = @theaterId";
            var seatsByTheater = db.Query<object>(sql, new { theaterId = theaterId }).SingleOrDefault();
            return seatsByTheater;
        }
    }
}
