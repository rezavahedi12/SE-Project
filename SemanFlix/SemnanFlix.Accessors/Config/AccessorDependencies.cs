using SemnanFlix.Accessors.Accessors;
using SemnanFlix.Accessors.Database;
using SemnanFlix.Accessors.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace SemnanFlix.Accessors.Config
{
    public static class AccessorDependencies
    {
        public static IServiceCollection AddAccessorDependencies(this IServiceCollection services)
        {
            if (services == null)
            {
                throw new ArgumentNullException(nameof(services));
            }

            services.AddTransient<DbContext, SemnanFlixContext>();

            services.AddTransient<ICastMemberAccessor, CastMemberAccessor>();
            services.AddTransient<ICrewMemberAccessor, CrewMemberAccessor>();
            services.AddTransient<IGenreAccessor, GenreAccessor>();
            services.AddTransient<IDepartmentAccessor, DepartmentAccessor>();
            services.AddTransient<IMovieAccessor, MovieAccessor>();
            services.AddTransient<IMovieGenreAccessor, MovieGenreAccessor>();
            services.AddTransient<IPersonAccessor, PersonAccessor>();
            services.AddTransient<IUserMovieAccessor, UserMovieAccessor>();

            return services;
        }
    }
}
