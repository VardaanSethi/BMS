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
        private readonly IMapper Mapper;

        public MovieService(IConfiguration configuration, IMapper mapper)
        {
            this.db = new SqlConnection(configuration.GetConnectionString("DefaultConnection"));
            this.Mapper = mapper;
        }
        public Movie GetMovie(int id)
        {
            return this.Mapper.Map<Movie>
                (this.db.Query<DataModel.Movie>($"SELECT * FROM Movies WHERE Id = {id}").SingleOrDefault());
        }

        public IEnumerable<Movie> GetMovies()
        {
            return this.Mapper.Map<IEnumerable<Movie>>
                (this.db.Query<DataModel.Movie>("SELECT * FROM Movies"));
        }
    }
}
