using AutoMapper;
using DataModel = BookMyShowWebAPI.Data;
using BookMyShowWebAPI.Models;
using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
            /*return this.Mapper.Map<Screen>
                (this.db.Query<DataModel.Screen>($"SELECT * FROM Screens WHERE Id = {id}").SingleOrDefault());*/
            return this.db.Query<DataModel.Screen>($"SELECT * FROM Screens WHERE Id = {id}").SingleOrDefault().MapTo<DataModel.Screen, Screen>();
        }

        public IEnumerable<Screen> GetScreens()
        {
            /*return this.Mapper.Map<IEnumerable<Screen>>
                (this.db.Query<DataModel.Screen>("SELECT * FROM Screens"));*/
            return this.db.Query<IEnumerable<DataModel.Screen>>("SELECT * FROM Screens").MapAllTo<IEnumerable<DataModel.Screen>, Screen>();
        }

        public Screen GetSeatsByTheater(int theaterId)
        {
            /*return db.Query<Screen>($"SELECT NoOfSeats FROM Screens WHERE Id = {theaterId}").SingleOrDefault();*/
            return this.db.Query<DataModel.Screen>($"SELECT NoOfSeats FROM Screens WHERE Id = {theaterId}").SingleOrDefault().MapTo<DataModel.Screen, Screen>();
        }
    }
}