using Microsoft.EntityFrameworkCore;
using EntityFrameworkCore.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EntityFrameworkCore.Mapping
{
    public class AuthorBiographyMapping : IEntityTypeConfiguration<AuthorBiography>
    {
        public void Configure(EntityTypeBuilder<AuthorBiography> builder)
        {
            builder.ToTable("AuthorBiographies");
            builder.HasKey(z => z.Id);
        }
    }
}
