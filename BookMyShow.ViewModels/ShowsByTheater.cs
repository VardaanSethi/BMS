using System;
using System.Collections.Generic;
using System.Text;

namespace BookMyShow.Models.ViewModels
{
    class ShowsByTheater
    {
        public int Id { get; set; }
        public DateTime Timing { get; set; }
        public int TheaterId { get; set; }
        public int MovieId { get; set; }
    }
}
