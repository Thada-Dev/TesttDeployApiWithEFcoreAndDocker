using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TesttDeployApiWithEFcoreAndDocker.Database.Entities;

namespace TesttDeployApiWithEFcoreAndDocker.Database.Configuraions
{
    public class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasKey(m => m.BookGUID);
            builder.HasOne(m => m.Student)
                .WithMany(m => m.Book)
                .HasForeignKey(m => m.StudentGUID);
        }
    }
}
