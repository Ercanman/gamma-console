using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gamma_console.Models
{
    public class Movie
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public int RuntimeMinutes { get; set; }
        public List<string> Genres { get; set; }

    }
}
