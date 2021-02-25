using BookMyShowWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookMyShowWebAPI.Services
{
    public interface IBookingService
    {
        IEnumerable<BookingModel> GetBookings();
        BookingModel GetBooking(int id);
        int PostBooking(BookingModel booking);
    }
}