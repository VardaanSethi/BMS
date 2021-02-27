using AutoMapper;
using DataModel = BookMyShowWebAPI.Data;
using BookMyShowWebAPI.Models;
using Dapper;
using Dapper.Contrib.Extensions;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
            /*return this.Mapper.Map<Booking>
                (this.db.Query<DataModel.Booking>($"SELECT * FROM Bookings WHERE Id = {0}", bookingId).SingleOrDefault());*/
            return this.db.Query<DataModel.Booking>($"SELECT * FROM Bookings WHERE Id = {0}", bookingId).SingleOrDefault().MapTo<DataModel.Booking, Booking>();
        }
        public IEnumerable<Booking> GetBookings()
        {
            /*return this.Mapper.Map<IEnumerable<Booking>>
                (this.db.Query<DataModel.Booking>("SELECT * FROM Bookings"));*/
            return this.db.Query<DataModel.Booking>("SELECT * FROM Bookings").MapAllTo<IEnumerable<DataModel.Booking>, Booking>();
        }
        public int PostBooking(Booking booking)
        {
            return (int)this.db.Insert(booking);
        }
    }
}