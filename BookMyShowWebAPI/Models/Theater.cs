using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookMyShowWebAPI.Models
{
    public class Theater
    {
        [Key]
        public int TheaterId { get; set; }
        public string TheaterName { get; set; }
        public string TheaterAddress { get; set; }
        public int noOfScreens { get; set; }
    }
}
