using BookMyShowWebAPI.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using Microsoft.Data.SqlClient;
using System.Data;
using BookMyShowWebAPI.Service;

namespace BookMyShowWebAPI.Services
{
    public class TheaterService : ITheaterService
    {
        private readonly IDbConnection db;
        public TheaterService(IConfiguration configuration)
        {
            this.db = new SqlConnection(configuration.GetConnectionString("DefaultConnection"));
        }
        public Theater GetTheater(int id)
        {
            return db.Query<Theater>("SELECT * FROM Theaters WHERE Id = @id", new { id = id }).SingleOrDefault();
        }

        public IEnumerable<Theater> GetTheaters()
        {
            return db.Query<Theater>("SELECT * FROM Theaters");
        }
    }
}
