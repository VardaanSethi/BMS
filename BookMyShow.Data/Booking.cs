using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookMyShowWebAPI.Data
{
    [Table("Booking")]
    public class Booking
    {
        public int TheaterId { get; set; }
        public int ShowId { get; set; }
        public int TicketPrice { get; set; }
        public int SeatNumber { get; set; }
        public DateTime Date { get; set; }
    }
}