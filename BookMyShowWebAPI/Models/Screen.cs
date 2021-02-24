using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookMyShowWebAPI.Models
{
    public class Screen
    {
        [Key]
        public int Id { get; set; }
        public int TheaterId { get; set; }
        public int MovieId { get; set; }
        public int NoOfSeats { get; set; }
    }
}
