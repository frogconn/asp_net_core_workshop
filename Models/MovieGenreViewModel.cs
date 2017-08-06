using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace MvcMovie.Models{

    public class MovieGenreViewModel{
        public List<Movie> movies { get; set; }
        public SelectList genres { get; set; }
        public string movieGenre { get; set; }
    }
}