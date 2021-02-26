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
    public class BookingController : ControllerBase
    {
        private readonly IBookingService Booking;

        public BookingController(IBookingService booking)
        {
            this.Booking = booking;
        }

        // GET: api/Booking
        [HttpGet]
        public IEnumerable<Booking> GetBookings()
        {
            return Booking.GetBookings();
        }

        // GET: api/Booking/5
        [HttpGet("{id}")]
        public Booking GetBooking(int id)
        {
            return Booking.GetBooking(id);
        }

        // POST: api/Booking
        [HttpPost]
        public int PostBooking(Booking booking)
        {
            return this.Booking.PostBooking(booking);
        }
    }
}
