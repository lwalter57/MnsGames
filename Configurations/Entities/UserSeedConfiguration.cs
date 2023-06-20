using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MnsGames.Data;

namespace MnsGames.Configurations.Entities
{
    public class UserSeedConfiguration : IEntityTypeConfiguration<AppUser>
    {

        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            var hasher = new PasswordHasher<AppUser>();
            builder.HasData(
                new AppUser
                {
                    Id = "367ee742-981e-470d-a02f-5decca03e7a8",
                    Email = "admin@admin.com",
                    NormalizedEmail = "ADMIN@ADMIN.com",
                    UserName = "admin@admin.com",
                    NormalizedUserName = "ADMIN@ADMIN.com",
                    FirstName = "System",
                    LastName = "Admin",
                    PasswordHash = hasher.HashPassword(null, "Maison_123"),
                    EmailConfirmed = true,
                },
                   new AppUser
                   {
                       Id = "17b4691e-4119-4ed4-990a-dc5186439777",
                       Email = "user@localhost.com",
                       NormalizedEmail = "USER@LOCALHOST.com",
                       UserName = "user@localhost.fr",
                       NormalizedUserName = "USER@LOCALHOST.com",
                       FirstName = "System",
                       LastName = "User",
                       PasswordHash = hasher.HashPassword(null, "Maison_123"),
                       EmailConfirmed = true,
                   }
            );
        }
    }
}