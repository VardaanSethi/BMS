using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookMyShowWebAPI.Data
{
    [Table("Bookings")]
    public class BookingDataModel
    {
        public int TheaterId { get; set; }
        public int ShowId { get; set; }
        public int TicketPrice { get; set; }
        public int SeatNumber { get; set; }
        public DateTime Date { get; set; }
    }
}