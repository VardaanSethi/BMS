using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BookMyShowWebAPI.Models;
using BookMyShowWebAPI.Services;

namespace BookMyShowWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShowController : ControllerBase
    {
        private readonly IShowService Show;

        public ShowController(IShowService show)
        {
            this.Show = show;
        }

        // GET: api/Show
        [HttpGet]
        public IEnumerable<Show> GetShows()
        {
            return Show.GetShows();
        }

        // GET: api/Show/5
        [HttpGet("{id}")]
        public Show GetShow(int id)
        {
            return Show.GetShow(id);
        }

        [HttpGet("theater/{theaterId}/movie/{movieId}")]
        public IActionResult ShowsByTheater(int theaterId, int movieId)
        {
            return Ok(Show.ShowsListByTheater(theaterId, movieId));
        }
    }
}
