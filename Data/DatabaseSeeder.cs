using InventoryApp.Models;
using InventoryApp.Services;
using Microsoft.EntityFrameworkCore;

namespace InventoryApp.Data
{
    public static class DatabaseSeeder
    {
        public static async Task SeedAsync(IServiceProvider services)
        {
            using var scope = services.CreateScope();
            var db = scope.ServiceProvider.GetRequiredService<AppDbContext>();
            var auth = scope.ServiceProvider.GetRequiredService<SimpleAuthService>();

            // Ensure database exists/migrated (safe here)
            await db.Database.MigrateAsync();

            // ADMIN seeding (insert only if missing)
            var admin = await db.Users.FirstOrDefaultAsync(u => u.Email == "admin@example.com");
            if (admin == null)
            {
                db.Users.Add(new User
                {
                    FullName = "Administrator",
                    Email = "admin@example.com",
                    PasswordHash = auth.HashPassword("admin123"),
                    Role = "Admin"
                });
            }

            // DEMO USER seeding (insert only if missing)
            var demo = await db.Users.FirstOrDefaultAsync(u => u.Email == "user@example.com");
            if (demo == null)
            {
                db.Users.Add(new User
                {
                    FullName = "Demo User",
                    Email = "user@example.com",
                    PasswordHash = auth.HashPassword("user123"),
                    Role = "User"
                });
            }

            await db.SaveChangesAsync();
        }
    }
}
