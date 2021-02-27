using BookMyShowWebAPI.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using Dapper.Contrib.Extensions;
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

        public TheaterService(IConfiguration configuration)
        {
            this.db = new SqlConnection(configuration.GetConnectionString("DefaultConnection"));
        }
        public Theater GetTheater(int id)
        {
            /*return this.Mapper.Map<Theater>
                (this.db.Query<DataModel.Theater>($"SELECT * FROM Theaters WHERE Id = {id}").SingleOrDefault());*/
            return this.db.Query<DataModel.Theater>($"SELECT * FROM Theaters WHERE Id = {id}").SingleOrDefault().MapTo<DataModel.Theater, Theater>();
        }

        public IEnumerable<Theater> GetTheaters()
        {
            /*return this.Mapper.Map<IEnumerable<Theater>>(this.db.Query<DataModel.Theater >("SELECT * FROM Theaters"));*/
            return this.db.Query<DataModel.Theater>("SELECT * FROM Theaters").MapAllTo<IEnumerable<DataModel.Theater>, Theater>();
        }
    }

    public static class MapToExtension
    {
        public static D MapTo<S, D>(this S data)
        {
            return Mapper.Map<D>(data);
        }

        public static IEnumerable<D> MapAllTo<S, D>(this S data)
        {
            return Mapper.Map<IEnumerable<D>>(data);
        }
    }
}