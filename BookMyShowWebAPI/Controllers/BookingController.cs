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
    public class BookingController : ControllerBase
    {
        private readonly IBookingService booking;

        public BookingController(IBookingService booking)
        {
            this.booking = booking;
        }

        // GET: api/Booking
        [HttpGet]
        public IEnumerable<Booking> GetBookings()
        {
            return booking.GetBookings();
        }

        // GET: api/Booking/5
        [HttpGet("{id}")]
        public IActionResult GetBooking(int id)
        {
            return Ok (booking.GetBookingById(id));
        }

        // POST: api/Booking
        [HttpPost]
        public IActionResult PostBooking(Booking booking)
        {
            return Ok(this.booking.PostBooking(booking));
        }
    }
}
