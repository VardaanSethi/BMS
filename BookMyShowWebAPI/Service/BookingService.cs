using BookMyShowWebAPI.Models;
using Dapper;
using Dapper.Contrib.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace BookMyShowWebAPI.Service
{
    public class BookingService : IBookingService
    {
        private readonly IDbConnection db;
        public BookingService(IConfiguration configuration)
        {
            this.db = new SqlConnection(configuration.GetConnectionString("DefaultConnection"));
        }
        public Booking GetBookingById(int bookingId)
        {
            var sql = "SELECT * FROM Bookings WHERE BookingId = @bookingId";
            var booking = db.Query<Booking>(sql, new { bookingId }).FirstOrDefault();
            return booking;
        }
        public List<Booking> GetBookings()
        {
            var sql = "SELECT * FROM Bookings";
            var bookingList = db.Query<Booking>(sql).ToList();
            return bookingList;
        }
        public int PostBooking(Booking booking)
        {
            return (int)this.db.Insert(booking);
        }
    }
}
