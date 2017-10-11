using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Api_ELearning.DataAccess.Models;

namespace Api_ELearning.DataAccess.Mappings
{
    public class EnrollmentMappings : EntityTypeConfiguration<Enrollment>
    {
        public EnrollmentMappings()
        {
            // Table
            ToTable("Mappings");

            // Primary Key
            Property(x=>x.Id).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            HasKey(x => x.Id);

            // Enrollment Date
            Property(x => x.EnrolledDate).IsRequired().HasColumnType("smalldatetime");

            // Foreign Keys
            HasOptional(x => x.Student).WithMany().Map(x => x.MapKey("StudentId")).WillCascadeOnDelete(false);
            HasOptional(x => x.Course).WithMany().Map(x => x.MapKey("CourseId")).WillCascadeOnDelete(false);
        }
    }
}