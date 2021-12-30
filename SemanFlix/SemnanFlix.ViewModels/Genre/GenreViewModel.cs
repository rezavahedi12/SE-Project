using SemnanFlix.Common.Utilities;
using SemnanFlix.ViewModels.Base;
using SemnanFlix.ViewModels.Movie;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace SemnanFlix.ViewModels.Genre
{
    public class GenreViewModel : EntityViewModel
    {
        [Required(AllowEmptyStrings = false)]
        public string Name { get; set; }

        public List<MovieViewModel> Movies { get; set; }

        public string MoviesTooltip { get { return Movies != null ? Movies.Select(x => x.Name).ToList().ToTooltipList() : ""; } }

        public string MoviesBulletedList { get { return Movies != null ? Movies.Select(x => x.Name).ToList().ToBulletedList() : ""; } }
    }
}
