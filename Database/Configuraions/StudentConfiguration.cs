using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TesttDeployApiWithEFcoreAndDocker.Database.Entities;

namespace TesttDeployApiWithEFcoreAndDocker.Database.Configuraions
{
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasKey(m => m.StudentGUID);
        }
    }
}
