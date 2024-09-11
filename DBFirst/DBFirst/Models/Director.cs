﻿using System;
using System.Collections.Generic;

#nullable disable

namespace DBFirst.Models
{
    public partial class Director
    {
        public Director()
        {
            Movies = new HashSet<Movie>();
        }

        public int Id { get; set; }
        public string DirectorName { get; set; }

        public virtual ICollection<Movie> Movies { get; set; }
    }
}
