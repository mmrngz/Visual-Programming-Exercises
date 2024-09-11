using System;
using System.Collections.Generic;

#nullable disable

namespace DBFirst.Models
{
    public partial class MovieActor
    {
        public int MovieId { get; set; }
        public int ActorsId { get; set; }

        public virtual Actor Actors { get; set; }
        public virtual Movie Movie { get; set; }
    }
}
