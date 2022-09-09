﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gamma_console.Models
{
    internal class MemberWithFavoriteMovies
    {
        public Guid Id { get; set; }
        public string FullName { get; set; }
        public string Team { get; set; }
        public List<Movie> FavoriteMovies { get; set; }
    }
}
