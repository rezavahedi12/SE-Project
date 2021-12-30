using SemnanFlix.Engines.Engines;
using SemnanFlix.Engines.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace SemnanFlix.Engines.Config
{
    public static class EngineDependencies
    {
        public static IServiceCollection AddEngineDependencies(this IServiceCollection services)
        {
            if (services == null)
            {
                throw new ArgumentNullException(nameof(services));
            }

            services.AddTransient<IMovieRoleUpdateEngine, MovieRoleUpdateEngine>();
            services.AddTransient<IMoviePurchaseEngine, MoviePurchaseEngine>();

            return services;
        }
    }
}
