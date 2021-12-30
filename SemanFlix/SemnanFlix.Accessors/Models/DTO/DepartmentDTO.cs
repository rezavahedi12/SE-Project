using SemnanFlix.Accessors.Models.DTO.Base;
using System.Collections.Generic;

namespace SemnanFlix.Accessors.Models.DTO
{
    public class DepartmentDTO : EntityDTO
    {
        public string Name { get; set; }

        public bool IsDirecting { get; set; }

        public ICollection<CrewMemberDTO> Roles { get; set; }
    }
}
