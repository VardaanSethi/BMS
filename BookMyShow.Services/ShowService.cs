using AutoMapper;
using DataModel = BookMyShowWebAPI.Data;
using BookMyShowWebAPI.Models;
using Dapper;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using BookMyShow.Models.ViewModel;

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
        public IEnumerable<Show> GetShowsListByTheater (int theaterId, int movieId)
        {
            return this.Mapper.Map<IEnumerable<Show>>
                (db.Query<ShowView>($"SELECT * FROM GetShowsByTheater WHERE TheaterId = {theaterId} AND MovieId = {movieId}"));
        }
        public Show GetShow(int id)
        {
            return this.Mapper.Map<Show>
                (this.db.Query<DataModel.Show>($"SELECT * FROM Shows WHERE Id = {id}").SingleOrDefault());
        }
        public IEnumerable<Show> GetShows()
        {
            return this.Mapper.Map<IEnumerable<Show>>
                (this.db.Query<DataModel.Show>("SELECT * FROM Shows"));
        }
    }
}