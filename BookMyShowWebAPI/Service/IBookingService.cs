using BookMyShowWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookMyShowWebAPI.Service
{
    public interface IBookingService
    {
        List<Booking> GetBookings();
        Booking GetBookingById(int id);
        int PostBooking(Booking booking);
    }
}
