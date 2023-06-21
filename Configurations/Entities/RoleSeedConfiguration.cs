using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using MnsGames.Constants;

namespace MnsGames.Configurations.Entities
{
    public class RoleSeedConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new IdentityRole
                {
                    Id = "bivz7894-ez8e-ehvnvz-nmqm719za4ea",
                    Name = Roles.Admin,
                    NormalizedName = Roles.Admin.ToUpper()
                },
                new IdentityRole
                {
                    Id = "biva7896-ez7f-ehvphz-nmqm917za4db",
                    Name = Roles.User,
                    NormalizedName = Roles.User.ToUpper()
                }
            );
        }
    }
}