using SemnanFlix.Accessors.Identity;
using SemnanFlix.Accessors.Models.EF;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace SemnanFlix.Accessors.Database
{
    public class SemnanFlixContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<CastMember> CastMembers { get; set; }
        public DbSet<CrewMember> CrewMembers { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<MovieGenre> MovieGenres { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<UserMovie> UserMovies { get; set; }

        public DbSet<RatingAndReview> RatingAndReview { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    if (!optionsBuilder.IsConfigured)
        //    {
        //        optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=SemnanFlixDb;Integrated Security=True;Trusted_Connection=True;MultipleActiveResultSets=true");
        //    }
        //}

        /// <summary>
        /// Default context
        /// </summary>
        /// <param name="options"></param>
        public SemnanFlixContext(DbContextOptions<SemnanFlixContext> options)
            : base(options)
        {
        }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            // Customize the ASP.NET Identity model and override the defaults if needed. Add your customizations after calling base.OnModelCreating(builder);
            base.OnModelCreating(builder);

            //Disable cascade deletions
            foreach (var relationship in builder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }

            //Seed data
            builder.SeedGenres();
            builder.SeedDepartments();
            builder.SeedPeople();
            builder.SeedMovies();
            builder.SeedMovieGenres();
            builder.SeedCastMembers();
            builder.SeedCrewMembers();
        }

        public virtual void SetState(object entity, EntityState state)
        {
            Entry(entity).State = state;
        }

        /// <summary>
        /// Detach all entries in the Context's Change Tracker.
        /// Very useful for avoiding tracking errors in testing.
        /// </summary>
        public virtual void DetachAll()
        {
            foreach (var entry in this.ChangeTracker.Entries().ToList())
            {
                entry.State = EntityState.Detached;
            }
        }
    }
}
