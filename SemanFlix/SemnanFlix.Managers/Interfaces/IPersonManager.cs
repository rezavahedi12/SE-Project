using SemnanFlix.Common.Models;
using SemnanFlix.ViewModels.Person;

namespace SemnanFlix.Managers.Interfaces
{
    public interface IPersonManager
    {
        PersonViewModel Get(int? id);

        PeopleViewModel GetAllByRequest(DataTableRequest query);

        PersonViewModel Save(PersonViewModel vm);

        PersonViewModel Delete(int id);
    }
}
