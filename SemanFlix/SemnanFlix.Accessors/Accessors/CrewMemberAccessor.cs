using AutoMapper;
using SemnanFlix.Accessors.Accessors.Base;
using SemnanFlix.Accessors.Database;
using SemnanFlix.Accessors.Interfaces;
using SemnanFlix.Accessors.Models.DTO;
using SemnanFlix.Accessors.Models.EF;
using SemnanFlix.Accessors.Models.EF.Base;
using System.Collections.Generic;
using System.Linq;

namespace SemnanFlix.Accessors.Accessors
{
    public class CrewMemberAccessor : EntityAccessor<Entity>, ICrewMemberAccessor
    {
        public CrewMemberAccessor(SemnanFlixContext db) : base(db)
        {
        }

        public List<CrewMemberDTO> SaveAll(int movieId, List<CrewMemberDTO> dtos)
        {
            //Create/update entries from crew list
            var entities = Mapper.Map<List<CrewMember>>(dtos ?? new List<CrewMemberDTO>());
            _db.CrewMembers.UpdateRange(entities);

            //Delete existing entries not in crew list
            var entityIds = entities.Select(x => x.Id);
            var entitiesToRemove = _db.CrewMembers.Where(x => x.MovieId == movieId && !entityIds.Contains(x.Id)).ToList();
            _db.CrewMembers.RemoveRange(entitiesToRemove);

            _db.SaveChanges();

            dtos = Mapper.Map<List<CrewMemberDTO>>(entities);

            return dtos;
        }

        public List<CrewMemberDTO> DeleteAllByMovie(int movieId)
        {
            var entities = _db.CrewMembers.Where(x => x.MovieId == movieId).ToList();

            _db.CrewMembers.RemoveRange(entities);
            _db.SaveChanges();

            var dtos = Mapper.Map<List<CrewMemberDTO>>(entities);

            return dtos;
        }
    }
}
