using System;

namespace BookMyShowWebAPI.Models
{
    public class BookingModel
    {
        public int TheaterId { get; set; }
        public int ShowId { get; set; }
        public int TicketPrice { get; set; }
        public int SeatNumber { get; set; }
        public DateTime Date { get; set; }
    }
}