using SemnanFlix.Accessors.Database;
using SemnanFlix.Accessors.Identity;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;

namespace SemnanFlix.Web.Config
{
    public static class DbInitializer
    {
        public async static void Run(IWebHost host)
        {
            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;

                try
                {
                    var context = services.GetRequiredService<SemnanFlixContext>();

                    //Create database if it doesn't exist and apply any pending migrations (this will also seed data)
                    context.Database.Migrate();
                    var password = new PasswordHasher<ApplicationUser>();
                    //Seed admin user
                    if (!context.Users.Any())
                    {   
                        var userManager = services.GetRequiredService<UserManager<ApplicationUser>>();

                        var admin = new ApplicationUser
                        {
                            UserName = "admin@SemnanFlix.com",
                            Email = "admin@SemnanFlix.com",
                            EmailConfirmed = true,
                            SecurityStamp = string.Empty
                        };

                        await userManager.CreateAsync(admin , "P@ss1234");
                    }
                }
                catch (Exception ex)
                {
                    var logger = services.GetRequiredService<ILogger<Program>>();
                    logger.LogError(ex, "An error occurred while seeding the database.");
                }
            }
        }
    }
}