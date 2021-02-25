using AutoMapper;
using BookMyShowWebAPI.Data;
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
        public BookingModel GetBooking(int bookingId)
        {
            return this.Mapper.Map<BookingModel>
                (this.db.Query<BookingDataModel>("SELECT * FROM Bookings WHERE Id = @bookingId", new { bookingId }).SingleOrDefault());
        }
        public IEnumerable<BookingModel> GetBookings()
        {
            return this.Mapper.Map<IEnumerable<BookingModel>>
                (this.db.Query<BookingDataModel>("SELECT * FROM Bookings"));
        }
        public int PostBooking(BookingModel booking)
        {
            return (int)this.db.Insert(booking);
        }
    }
}