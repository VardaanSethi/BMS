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
    public class ScreenController : ControllerBase
    {
        private readonly IScreenService Screen;

        public ScreenController(IScreenService screen)
        {
            this.Screen = screen;
        }

        // GET: api/Screen
        [HttpGet]
        public IEnumerable<Screen> GetScreens()
        {
            return Screen.GetScreens();
        }

        // GET: api/Screen/5
        [HttpGet("{id}")]
        public Screen GetScreen(int id)
        {
            return Screen.GetScreen(id);
        }

        [HttpGet("theater/{theaterId}")]
        public IActionResult GetSeatsByTheater(int theaterId)
        {
            return Ok(Screen.GetSeatsByTheater(theaterId));
        }
    }
}
