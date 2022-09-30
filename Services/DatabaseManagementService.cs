using Microsoft.EntityFrameworkCore;
using TesttDeployApiWithEFcoreAndDocker.Database;

namespace TesttDeployApiWithEFcoreAndDocker.Services
{
    public static class DatabaseManagementService
    {
        public static void MigrationInitialisation(this IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.CreateScope())
            {
                var serviceDb = serviceScope.ServiceProvider.GetService<DatabaseContext>();

                serviceDb!.Database.Migrate();
            }
        }
    }
}
