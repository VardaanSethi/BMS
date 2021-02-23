using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookMyShowWebAPI.Models
{
    public class Movie
    {
        [Key]
        public int MovieId { get; set; }
        public string MovieTitle { get; set; }
        public string MovieDescription { get; set; }
        public string MovieLanguage { get; set; }
    }
}
