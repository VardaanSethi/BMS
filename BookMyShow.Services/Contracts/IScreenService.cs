using BookMyShowWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookMyShowWebAPI.Services
{
    public interface IScreenService
    {
        IEnumerable<Screen> GetScreens();
        Screen GetScreen(int id);
        object GetSeatsByTheater(int theaterId);
    }
}
