using SemnanFlix.Accessors.Models.DTO;
using SemnanFlix.Common.Models;
using System.Collections.Generic;

namespace SemnanFlix.Accessors.Interfaces
{
    public interface IGenreAccessor
    {
        GenreDTO Get(int id);

        List<GenreDTO> GetAll();

        List<GenreDTO> GetAllByRequest(DataTableRequest query);

        int GetCount(string search = null);

        GenreDTO Save(GenreDTO dto);

        GenreDTO Delete(int id);
    }
}
