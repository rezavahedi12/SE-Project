using SemnanFlix.ViewModels.Shared;
using System.Collections.Generic;

namespace SemnanFlix.ViewModels.Person
{
    public class PeopleViewModel
    {
        public List<PersonViewModel> People { get; set; }

        public DataTableViewModel DataTable { get; set; }
    }
}
