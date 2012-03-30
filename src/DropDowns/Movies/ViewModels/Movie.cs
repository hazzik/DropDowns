using System.Collections.Generic;

namespace SampleApplication.Movies.ViewModels
{
    public class Movie
    {
        public int GenreId { get; set; }

        public IEnumerable<int> Years { get; set; }
    }
}
