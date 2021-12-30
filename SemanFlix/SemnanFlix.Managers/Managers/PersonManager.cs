using AutoMapper;
using SemnanFlix.Accessors.Interfaces;
using SemnanFlix.Accessors.Models.DTO;
using SemnanFlix.Common.Models;
using SemnanFlix.Managers.Interfaces;
using SemnanFlix.ViewModels.Person;
using SemnanFlix.ViewModels.Shared;
using System.Collections.Generic;
using System.Linq;

namespace SemnanFlix.Managers.Managers
{
    public class PersonManager : IPersonManager
    {
        private IPersonAccessor _personAccessor;

        public PersonManager(IPersonAccessor personAccessor)
        {
            _personAccessor = personAccessor;
        }

        public PersonViewModel Get(int? id)
        {
            var dto = id.HasValue ? _personAccessor.Get(id.Value) : new PersonDTO();
            var vm = Mapper.Map<PersonViewModel>(dto);

            vm.Roles = vm.Roles.OrderByDescending(x => x.MovieYear).ThenBy(x => x.MovieName).ToList();

            return vm;
        }

        public PeopleViewModel GetAllByRequest(DataTableRequest request)
        {
            var dtos = _personAccessor.GetAllByRequest(request);
            var vms = Mapper.Map<List<PersonViewModel>>(dtos);

            vms.ForEach(x => x.Roles.OrderBy(y => y.MovieName));

            var filteredCount = _personAccessor.GetCount(request.Search);
            var totalCount = _personAccessor.GetCount();

            return new PeopleViewModel {
                People = vms,
                DataTable = new DataTableViewModel(request, filteredCount, totalCount)
            };
        }

        public PersonViewModel Save(PersonViewModel vm)
        {
            var dto = Mapper.Map<PersonDTO>(vm);

            dto = _personAccessor.Save(dto);
            vm = Mapper.Map<PersonViewModel>(dto);

            return vm;
        }

        public PersonViewModel Delete(int id)
        {
            var dto = _personAccessor.Delete(id);
            var vm = Mapper.Map<PersonViewModel>(dto);

            return vm;
        }
    }
}
