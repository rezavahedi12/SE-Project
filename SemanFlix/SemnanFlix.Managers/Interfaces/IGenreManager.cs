using SemnanFlix.Common.Models;
using SemnanFlix.ViewModels.Genre;

namespace SemnanFlix.Managers.Interfaces
{
    public interface IGenreManager
    {
        GenreViewModel Get(int? id);

        GenresViewModel GetAllByRequest(DataTableRequest query);

        GenreViewModel Save(GenreViewModel vm);

        GenreViewModel Delete(int id);
    }
}
