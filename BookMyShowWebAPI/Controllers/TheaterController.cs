using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BookMyShowWebAPI.Models;
using BookMyShowWebAPI.Services;
using BookMyShowWebAPI.Service;

namespace BookMyShowWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TheaterController : ControllerBase
    {
        private readonly ITheaterService Theater;

        public TheaterController(ITheaterService theater)
        {
            this.Theater = theater;
        }

        // GET: api/Theater
        [HttpGet]
        public IEnumerable<Theater> GetTheaters()
        {
            return Theater.GetTheaters();
        }

        // GET: api/Theater/5
        [HttpGet("{id}")]
        public Theater GetTheater(int id)
        {
            return Theater.GetTheater(id);
        }
    }
}
