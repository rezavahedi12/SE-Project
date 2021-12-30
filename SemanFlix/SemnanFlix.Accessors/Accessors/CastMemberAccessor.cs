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
    public class CastMemberAccessor : EntityAccessor<Entity>, ICastMemberAccessor
    {
        public CastMemberAccessor(SemnanFlixContext db) : base(db)
        {
        }

        public List<CastMemberDTO> SaveAll(int movieId, List<CastMemberDTO> dtos)
        {
            //Create/update entries from cast list
            var entities = Mapper.Map<List<CastMember>>(dtos ?? new List<CastMemberDTO>());
            _db.CastMembers.UpdateRange(entities);

            //Delete existing entries not in cast list
            var entityIds = entities.Select(x => x.Id);
            var entitiesToRemove = _db.CastMembers.Where(x => x.MovieId == movieId && !entityIds.Contains(x.Id)).ToList();
            _db.CastMembers.RemoveRange(entitiesToRemove);

            _db.SaveChanges();

            dtos = Mapper.Map<List<CastMemberDTO>>(entities);

            return dtos;
        }

        public List<CastMemberDTO> DeleteAllByMovie(int movieId)
        {
            var entities = _db.CastMembers.Where(x => x.MovieId == movieId).ToList();

            _db.CastMembers.RemoveRange(entities);
            _db.SaveChanges();

            var dtos = Mapper.Map<List<CastMemberDTO>>(entities);

            return dtos;
        }
    }
}
