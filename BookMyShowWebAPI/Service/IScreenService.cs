using BookMyShowWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookMyShowWebAPI.Service
{
    public interface IScreenService
    {
        public List<Screen> GetScreens();
        public Screen GetScreenById(int id);
        public object GetSeatsByTheater(int theaterId);
    }
}
