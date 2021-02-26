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
        private readonly IMapper Mapper;

        public ScreenService(IConfiguration configuration, IMapper mapper)
        {
            this.db = new SqlConnection(configuration.GetConnectionString("DefaultConnection"));
            this.Mapper = mapper;
        }
        public Screen GetScreen(int id)
        {
            return this.Mapper.Map<Screen>
                (this.db.Query<DataModel.Screen>("SELECT * FROM Screens WHERE Id = @id", new { id = id }).SingleOrDefault());
        }

        public IEnumerable<Screen> GetScreens()
        {
            return this.Mapper.Map<IEnumerable<Screen>>
                (this.db.Query<DataModel.Screen>("SELECT * FROM Screens"));
        }

        public object GetSeatsByTheater(int theaterId)
        {
            return db.Query<object>("SELECT NoOfSeats FROM Screens WHERE Id = @theaterId", new { theaterId = theaterId }).SingleOrDefault();
        }
    }
}
