using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BookMyShowWebAPI.Models;
using BookMyShowWebAPI.Service;

namespace BookMyShowWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TheaterController : ControllerBase
    {
        private readonly ITheaterService theater;

        public TheaterController(ITheaterService theater)
        {
            this.theater = theater;
        }

        // GET: api/Theater
        [HttpGet]
        public IEnumerable<Theater> GetTheaters()
        {
            return theater.GetTheaters();
        }

        // GET: api/Theater/5
        [HttpGet("{id}")]
        public Theater GetTheater(int id)
        {
            return theater.GetTheaterById(id);
        }
    }
}
