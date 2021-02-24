using BookMyShowWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookMyShowWebAPI.Services
{
    public interface IScreenService
    {
        public IEnumerable<Screen> GetScreens();
        public Screen GetScreen(int id);
        public object GetSeatsByTheater(int theaterId);
    }
}
