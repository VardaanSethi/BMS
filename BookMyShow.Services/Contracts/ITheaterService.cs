using BookMyShowWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookMyShowWebAPI.Service
{
    public interface ITheaterService
    {
        IEnumerable<TheaterModel> GetTheaters();
        TheaterModel GetTheater(int id);
    }
}