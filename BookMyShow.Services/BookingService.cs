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
        private readonly IMapper Mapper;

        public BookingService(IConfiguration configuration,IMapper mapper)
        {
            this.db = new SqlConnection(configuration.GetConnectionString("DefaultConnection"));
            this.Mapper = mapper;
        }
        public Booking GetBooking(int bookingId)
        {
            return this.Mapper.Map<Booking>
                (this.db.Query<DataModel.Booking>($"SELECT * FROM Bookings WHERE Id = {0}", bookingId).SingleOrDefault());
        }
        public IEnumerable<Booking> GetBookings()
        {
            return this.Mapper.Map<IEnumerable<Booking>>
                (this.db.Query<DataModel.Booking>("SELECT * FROM Bookings"));
        }
        public int PostBooking(Booking booking)
        {
            return (int)this.db.Insert(booking);
        }
    }
}