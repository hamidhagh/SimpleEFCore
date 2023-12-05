using EntityFrameworkCore.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EntityFrameworkCore.Mapping
{
    public class BookCategoryMapping : IEntityTypeConfiguration<BookCategory>
    {
        public void Configure(EntityTypeBuilder<BookCategory> builder)
        {
            builder.ToTable("BookCategories");
            builder.HasKey(x => new { x.BookId, x.CategoryId });

            builder.HasOne(x => x.Book).WithMany(x => x.BookCategories).HasForeignKey(z => z.BookId);

            builder.HasOne(z => z.Category).WithMany(z => z.BookCategories).HasForeignKey(z => z.CategoryId);
        }
    }
}
