using BookMyShowWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookMyShowWebAPI.Service
{
    public interface ITheaterService
    {
        public List<Theater> GetTheaters();
        public Theater GetTheaterById(int id);
    }
}