using System.ComponentModel.DataAnnotations;

namespace SemnanFlix.Accessors.Models.EF.Base
{
    public abstract class Entity
    {
        [Key]
        public virtual int Id { get; set; }
    }
}
