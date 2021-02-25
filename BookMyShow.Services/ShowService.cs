using AutoMapper;
using BookMyShowWebAPI.Data;
using BookMyShowWebAPI.Models;
using Dapper;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace BookMyShowWebAPI.Services
{
    public class ShowService : IShowService
    {
        private readonly IDbConnection db;
        private readonly IMapper Mapper;

        public ShowService(IConfiguration configuration, IMapper mapper)
        {
            this.db = new SqlConnection(configuration.GetConnectionString("DefaultConnection"));
            this.Mapper = mapper;
        }
        public IEnumerable<object> ShowsListByTheater (int theaterId, int movieId)
        {
            return this.Mapper.Map<IEnumerable<object>>
                (db.Query<object>("SELECT * FROM GetShowsByTheater WHERE TheaterId = @theaterId AND MovieId = @movieId", new { theaterId = theaterId, movieId = movieId }));
        }
        public ShowModel GetShow(int id)
        {
            return this.Mapper.Map<ShowModel>
                (this.db.Query<ShowDataModel>("SELECT * FROM Shows WHERE Id = @id", new { id = id }).SingleOrDefault());
        }
        public IEnumerable<ShowModel> GetShows()
        {
            return this.Mapper.Map<IEnumerable<ShowModel>>
                (this.db.Query<ShowDataModel>("SELECT * FROM Shows"));
        }
    }
}