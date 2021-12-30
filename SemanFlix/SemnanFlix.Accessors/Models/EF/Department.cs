using SemnanFlix.Accessors.Models.EF.Base;
using System.Collections.Generic;

namespace SemnanFlix.Accessors.Models.EF
{
    public class Department : Entity
    {
        public string Name { get; set; }

        public bool IsDirecting { get; set; }

        public virtual ICollection<CrewMember> Roles { get; set; }
    }
}
