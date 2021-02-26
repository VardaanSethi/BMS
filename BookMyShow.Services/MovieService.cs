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
    public class MovieService : IMovieService
    {
        private readonly IDbConnection db;

        public MovieService(IConfiguration configuration)
        {
            this.db = new SqlConnection(configuration.GetConnectionString("DefaultConnection"));
        }
        public Movie GetMovie(int id)
        {
            /*return this.Mapper.Map<Movie>
                (this.db.Query<DataModel.Movie>($"SELECT * FROM Movies WHERE Id = {id}").SingleOrDefault());*/
            return this.db.Query<DataModel.Movie>($"SELECT * FROM Movies WHERE Id = {id}").SingleOrDefault().MapTo<DataModel.Movie, Movie>();
        }

        public IEnumerable<Movie> GetMovies()
        {
            /*return this.Mapper.Map<IEnumerable<Movie>>
                (this.db.Query<DataModel.Movie>("SELECT * FROM Movies"));*/
            return this.db.Query<IEnumerable<DataModel.Movie>>("SELECT * FROM Movies").MapAllTo<IEnumerable<DataModel.Movie>, Movie>();
        }
    }
}
