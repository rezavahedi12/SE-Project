using AutoMapper;
using SemnanFlix.Accessors.Accessors.Base;
using SemnanFlix.Accessors.Database;
using SemnanFlix.Accessors.Interfaces;
using SemnanFlix.Accessors.Models.DTO;
using SemnanFlix.Accessors.Models.EF;
using SemnanFlix.Accessors.Models.EF.Base;
using SemnanFlix.Common.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace SemnanFlix.Accessors.Accessors
{
    public class DepartmentAccessor : EntityAccessor<Entity>, IDepartmentAccessor
    {
        public DepartmentAccessor(SemnanFlixContext db) : base(db)
        {
        }

        public DepartmentDTO Get(int id)
        {
            var entity = _db.Departments.Single(x => x.Id == id);

            var dto = Mapper.Map<DepartmentDTO>(entity);

            return dto;
        }

        public List<DepartmentDTO> GetAllByRequest(DataTableRequest request)
        {
            var query = _db.Departments.AsNoTracking().AsQueryable();

            if (!string.IsNullOrEmpty(request.Search))
            {
                query = query.Where(x => x.Name.ToLower().Contains(request.Search.ToLower()));
            }

            switch (request.SortOrder)
            {
                case "Name_Asc":
                    query = query.OrderBy(x => x.Name);
                    break;

                case "Name_Desc":
                    query = query.OrderByDescending(x => x.Name);
                    break;

                case "Roles_Asc":
                    query = query.OrderBy(x => x.Roles.Count());
                    break;

                case "Roles_Desc":
                    query = query.OrderByDescending(x => x.Roles.Count());
                    break;
            }

            var entities = query
                .Skip((request.PageIndex - 1) * request.PageSize)
                .Take(request.PageSize)
                .ToList();

            var dtos = Mapper.Map<List<DepartmentDTO>>(entities);

            return dtos;
        }

        public List<DepartmentDTO> GetAllByName(string query)
        {
            var entities = _db.Departments
                .Where(x => x.Name.ToLower().Contains(query.ToLower()))
                .ToList();

            var dtos = Mapper.Map<List<DepartmentDTO>>(entities);

            return dtos;
        }

        public int GetCount(string search = null)
        {
            if (!string.IsNullOrEmpty(search))
            {
                return _db.Departments.Where(x => x.Name.ToLower().Contains(search.ToLower())).Count();
            }
            else
            {
                return _db.Departments.Count();
            }
        }

        public int GetRoleCount(int id)
        {
            return _db.Departments
                .Include(x => x.Roles)
                .Single(x => x.Id == id)
                .Roles
                .Count();
        }

        public DepartmentDTO Save(DepartmentDTO dto)
        {
            var entity = Mapper.Map<Department>(dto);

            _db.Departments.Update(entity);
            _db.SaveChanges();

            dto = Mapper.Map<DepartmentDTO>(entity);

            return dto;
        }

        public DepartmentDTO Delete(int id)
        {
            var entity = _db.Departments.Single(x => x.Id == id);

            _db.Departments.Remove(entity);
            _db.SaveChanges();

            var dto = Mapper.Map<DepartmentDTO>(entity);

            return dto;
        }
    }
}
