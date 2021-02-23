using BookMyShowWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookMyShowWebAPI.Service
{
    public interface IShowService
    {
        public List<Show> GetShows();
        public Show GetShowById(int id);
        public List<object> ShowsListByTheater(int theaterId, int movieId);
    }
}
