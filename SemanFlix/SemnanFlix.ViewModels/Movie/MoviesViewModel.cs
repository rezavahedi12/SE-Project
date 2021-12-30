using SemnanFlix.ViewModels.Shared;
using System.Collections.Generic;

namespace SemnanFlix.ViewModels.Movie
{
    public class MoviesViewModel
    {
        public List<MovieViewModel> Movies { get; set; }

        public DataTableViewModel DataTable { get; set; }
    }
}
