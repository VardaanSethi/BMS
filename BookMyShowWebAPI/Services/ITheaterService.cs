using BookMyShowWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookMyShowWebAPI.Service
{
    public interface ITheaterService
    {
        public IEnumerable<Theater> GetTheaters();
        public Theater GetTheater(int id);
    }
}