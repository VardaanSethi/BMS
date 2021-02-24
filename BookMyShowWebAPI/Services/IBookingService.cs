using BookMyShowWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookMyShowWebAPI.Services
{
    public interface IBookingService
    {
        IEnumerable<Booking> GetBookings();
        Booking GetBooking(int id);
        int PostBooking(Booking booking);
    }
}
