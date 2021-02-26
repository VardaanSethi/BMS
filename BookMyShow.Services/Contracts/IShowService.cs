using BookMyShowWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookMyShowWebAPI.Services
{
    public interface IShowService
    {
        IEnumerable<Show> GetShows();
        Show GetShow(int id);
        IEnumerable<Show> GetShowsListByTheater(int theaterId, int movieId);
    }
}
