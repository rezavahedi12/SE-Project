using SemnanFlix.Common.Models;
using SemnanFlix.ViewModels.Department;

namespace SemnanFlix.Managers.Interfaces
{
    public interface IDepartmentManager
    {
        DepartmentViewModel Get(int? id);

        DepartmentsViewModel GetAllByRequest(DataTableRequest query);

        DepartmentViewModel Save(DepartmentViewModel vm);

        DepartmentViewModel Delete(int id);
    }
}
