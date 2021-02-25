using AutoMapper;
using BookMyShowWebAPI.Data;
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
        public ScreenModel GetScreen(int id)
        {
            return this.Mapper.Map<ScreenModel>
                (this.db.Query<ScreenDataModel>("SELECT * FROM Screens WHERE Id = @id", new { id = id }).SingleOrDefault());
        }

        public IEnumerable<ScreenModel> GetScreens()
        {
            return this.Mapper.Map<IEnumerable<ScreenModel>>
                (this.db.Query<ScreenDataModel>("SELECT * FROM Screens"));
        }

        public object GetSeatsByTheater(int theaterId)
        {
            return db.Query<object>("SELECT NoOfSeats FROM Screens WHERE Id = @theaterId", new { theaterId = theaterId }).SingleOrDefault();
        }
    }
}
