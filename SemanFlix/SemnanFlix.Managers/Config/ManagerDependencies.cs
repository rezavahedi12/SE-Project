using SemnanFlix.Accessors.Identity;
using SemnanFlix.Managers.Interfaces;
using SemnanFlix.Managers.Managers;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace SemnanFlix.Managers.Config
{
    public static class ManagerDependencies
    {
        public static IServiceCollection AddManagerDependencies(this IServiceCollection services)
        {
            if (services == null)
            {
                throw new ArgumentNullException(nameof(services));
            }

            services.AddTransient<ApplicationUserManager>();
            services.AddTransient<ApplicationSignInManager>();

            services.AddTransient<IAccountManager, AccountManager>();
            services.AddTransient<IDepartmentManager, DepartmentManager>();
            services.AddTransient<IEmailManager, EmailManager>();
            services.AddTransient<IGenreManager, GenreManager>();
            services.AddTransient<IMovieManager, MovieManager>();
            services.AddTransient<IPersonManager, PersonManager>();

            return services;
        }
    }
}
