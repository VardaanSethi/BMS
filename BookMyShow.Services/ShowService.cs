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

        public ShowService(IConfiguration configuration)
        {
            this.db = new SqlConnection(configuration.GetConnectionString("DefaultConnection"));
        }
        public IEnumerable<Show> GetShowsListByTheater (int theaterId, int movieId)
        {
            /*return this.Mapper.Map<IEnumerable<Show>>
                (db.Query<ShowView>($"SELECT * FROM GetShowsByTheater WHERE TheaterId = {theaterId} AND MovieId = {movieId}"));*/
            return this.db.Query<ShowView>($"SELECT * FROM GetShowsByTheater WHERE TheaterId = {theaterId} AND MovieId = {movieId}").MapAllTo<IEnumerable<ShowView>, Show>();
        }
        public Show GetShow(int id)
        {
            /*return this.Mapper.Map<Show>
                (this.db.Query<DataModel.Show>($"SELECT * FROM Shows WHERE Id = {id}").SingleOrDefault());*/
            return this.db.Query<DataModel.Show>($"SELECT * FROM Shows WHERE Id = {id}").SingleOrDefault().MapTo<DataModel.Show, Show>();

        }
        public IEnumerable<Show> GetShows()
        {
            /*return this.Mapper.Map<IEnumerable<Show>>
                (this.db.Query<DataModel.Show>("SELECT * FROM Shows"));*/
            return this.db.Query<DataModel.Show>("SELECT * FROM Shows").MapAllTo<IEnumerable<DataModel.Show>, Show>();

        }
    }
}