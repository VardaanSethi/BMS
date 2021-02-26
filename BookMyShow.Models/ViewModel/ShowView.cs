using System;

namespace BookMyShow.Models.ViewModel
{
    public class ShowView
    {
        public int Id { get; set; }
        public DateTime Timing { get; set; }
        public int TheaterId { get; set; }
        public int MovieId { get; set; }
    }
}
