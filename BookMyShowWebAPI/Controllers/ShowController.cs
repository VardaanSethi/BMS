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
    public class ShowController : ControllerBase
    {
        private readonly IShowService show;

        public ShowController(IShowService show)
        {
            this.show = show;
        }

        // GET: api/Show
        [HttpGet]
        public IEnumerable<Show> GetShows()
        {
            return show.GetShows();
        }

        // GET: api/Show/5
        [HttpGet("{id}")]
        public Show GetShow(int id)
        {
            return show.GetShowById(id);
        }

        [Route("showbytheater/{theaterId}/movie/{movieId}")]
        [HttpGet]
        public IActionResult ShowsByTheater(int theaterId, int movieId)
        {
            return Ok( show.ShowsListByTheater(theaterId, movieId));
        }
    }
}
