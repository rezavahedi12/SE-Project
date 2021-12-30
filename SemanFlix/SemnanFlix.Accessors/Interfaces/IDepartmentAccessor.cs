using SemnanFlix.Accessors.Models.DTO;
using SemnanFlix.Common.Models;
using System.Collections.Generic;

namespace SemnanFlix.Accessors.Interfaces
{
    public interface IDepartmentAccessor
    {
        DepartmentDTO Get(int id);

        List<DepartmentDTO> GetAllByRequest(DataTableRequest query);

        List<DepartmentDTO> GetAllByName(string query);

        int GetCount(string search = null);

        int GetRoleCount(int id);

        DepartmentDTO Save(DepartmentDTO dto);

        DepartmentDTO Delete(int id);
    }
}
