using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace BookMyShowWebAPI.Models
{
    [Table("Bookings")]
    public class Booking
    {
        public int TheaterId { get; set; }
        public int ShowId { get; set; }
        public int TicketPrice { get; set; }
        public int SeatNumber { get; set; }
        public DateTime Date { get; set; }
    }
}