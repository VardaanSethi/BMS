using BookMyShowWebAPI.Models;
using Dapper;
using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace BookMyShowWebAPI.Services
{
    public class BookingService : IBookingService
    {
        private readonly IDbConnection db;
        public BookingService(IConfiguration configuration)
        {
            this.db = new SqlConnection(configuration.GetConnectionString("DefaultConnection"));
        }
        public Booking GetBooking(int bookingId)
        {
            return db.Query<Booking>("SELECT * FROM Bookings WHERE Id = @bookingId", new { bookingId }).SingleOrDefault();
        }
        public IEnumerable<Booking> GetBookings()
        {
            return db.Query<Booking>("SELECT * FROM Bookings");
        }
        public int PostBooking(Booking booking)
        {
            return (int)this.db.Insert(booking);
        }
    }
}