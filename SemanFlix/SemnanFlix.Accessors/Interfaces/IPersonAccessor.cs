using SemnanFlix.Accessors.Models.DTO;
using SemnanFlix.Common.Models;
using System.Collections.Generic;

namespace SemnanFlix.Accessors.Interfaces
{
    public interface IPersonAccessor
    {
        PersonDTO Get(int id);

        List<PersonDTO> GetAllByRequest(DataTableRequest query);

        List<PersonDTO> GetAllByName(string query);

        int GetCount(string search = null);

        PersonDTO Save(PersonDTO dto);

        PersonDTO Delete(int id);
    }
}
