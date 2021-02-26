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
using DataModel = BookMyShowWebAPI.Data;

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
        public Theater GetTheater(int id)
        {
            return this.Mapper.Map<Theater>
                (this.db.Query<DataModel.Theater>($"SELECT * FROM Theaters WHERE Id = {id}").SingleOrDefault());
        }

        public IEnumerable<Theater> GetTheaters()
        {
            return this.Mapper.Map<IEnumerable<Models.Theater>>(this.db.Query<DataModel.Theater >("SELECT * FROM Theaters"));
        }
    }
}