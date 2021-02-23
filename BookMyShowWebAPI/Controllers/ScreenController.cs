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
    public class ScreenController : ControllerBase
    {
        private readonly IScreenService screen;

        public ScreenController(IScreenService screen)
        {
            this.screen = screen;
        }

        // GET: api/Screen
        [HttpGet]
        public IEnumerable<Screen> GetScreens()
        {
            return screen.GetScreens();
        }

        // GET: api/Screen/5
        [HttpGet("{id}")]
        public Screen GetScreen(int id)
        {
            return screen.GetScreenById(id);
        }

        [Route("seatsbytheater/{theaterId}")]
        [HttpGet]
        public IActionResult GetSeatsByTheater(int theaterId)
        {
            return Ok(screen.GetSeatsByTheater(theaterId));
        }
    }
}
