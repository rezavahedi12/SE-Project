using SemnanFlix.ViewModels.Shared;
using System.Collections.Generic;

namespace SemnanFlix.ViewModels.Department
{
    public class DepartmentsViewModel
    {
        public List<DepartmentViewModel> Departments { get; set; }

        public DataTableViewModel DataTable { get; set; }
    }
}
