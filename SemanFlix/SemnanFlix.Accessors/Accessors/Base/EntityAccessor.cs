using SemnanFlix.Accessors.Database;
using SemnanFlix.Accessors.Models.EF.Base;
using Microsoft.EntityFrameworkCore;

namespace SemnanFlix.Accessors.Accessors.Base
{
    public abstract class EntityAccessor<TEntity> where TEntity : Entity
    {
        protected readonly SemnanFlixContext _db;

        public EntityAccessor(SemnanFlixContext db)
        {
            //Disable global tracking: https://docs.microsoft.com/en-us/ef/core/querying/tracking
            db.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;

            _db = db;
        }
    }
}
