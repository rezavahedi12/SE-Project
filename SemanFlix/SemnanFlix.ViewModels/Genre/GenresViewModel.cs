using SemnanFlix.ViewModels.Shared;
using System.Collections.Generic;

namespace SemnanFlix.ViewModels.Genre
{
    public class GenresViewModel
    {
        public List<GenreViewModel> Genres { get; set; }

        public DataTableViewModel DataTable { get; set; }
    }
}
