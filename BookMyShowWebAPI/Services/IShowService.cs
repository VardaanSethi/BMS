using BookMyShowWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookMyShowWebAPI.Services
{
    public interface IShowService
    {
        public IEnumerable<Show> GetShows();
        public Show GetShow(int id);
        public IEnumerable<object> ShowsListByTheater(int theaterId, int movieId);
    }
}
