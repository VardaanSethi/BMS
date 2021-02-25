using BookMyShowWebAPI.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using System.Data;
using BookMyShowWebAPI.Service;
using System.Data.SqlClient;
using AutoMapper;
using BookMyShowWebAPI.Data;

namespace BookMyShowWebAPI.Services
{
    public class TheaterService : ITheaterService
    {
        private readonly IDbConnection db;
        private readonly IMapper Mapper;

        public TheaterService(IConfiguration configuration, IMapper mapper)
        {
            this.db = new SqlConnection(configuration.GetConnectionString("DefaultConnection"));
            this.Mapper = mapper;
        }
        public TheaterModel GetTheater(int id)
        {
            return this.Mapper.Map<TheaterModel>
                (this.db.Query<TheaterDataModel>("SELECT * FROM Theaters WHERE Id = @id", new { id = id }).SingleOrDefault());
        }

        public IEnumerable<TheaterModel> GetTheaters()
        {
            return this.Mapper.Map<IEnumerable<TheaterModel>>(this.db.Query<TheaterDataModel>("SELECT * FROM Theaters"));
        }
    }
}