using BookMyShowWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookMyShowWebAPI.Services
{
    public interface IShowService
    {
        IEnumerable<ShowModel> GetShows();
        ShowModel GetShow(int id);
        IEnumerable<object> ShowsListByTheater(int theaterId, int movieId);
    }
}
