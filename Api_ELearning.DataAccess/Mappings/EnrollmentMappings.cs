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
            HasRequired(x => x.Student).WithMany(x=>x.Enrollments);
            HasRequired(x => x.Course).WithMany(x=>x.Enrollments);
        }
    }
}