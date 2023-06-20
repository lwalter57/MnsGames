using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MnsGames.Configurations.Entities
{
    public class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "bivz7894-ez8e-ehvnvz-nmqm719za4ea",
                    UserId = "367ee742-981e-470d-a02f-5decca03e7a8"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "biva7896-ez7f-ehvphz-nmqm917za4db",
                    UserId = "17b4691e-4119-4ed4-990a-dc5186439777"
                }
                );
        }

    }
}