using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Api_ELearning.DataAccess.Models;

namespace Api_ELearning.DataAccess.Mappings
{
    public class CourseMappings : EntityTypeConfiguration<Course>
    {
        public CourseMappings()
        {
            // Table
            ToTable("Courses");

            // Primary Key
            Property(x => x.Id).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            HasKey(x => x.Id);

            // Name
            Property(x => x.Name).IsRequired().HasMaxLength(255);

            // Duration
            Property(x => x.Duration).IsRequired();

            // Description
            Property(x => x.Description).IsOptional().HasMaxLength(1000);

            // Foreign Keys
            HasRequired(x => x.Subject).WithMany(x=>x.Courses).WillCascadeOnDelete(false);
            HasRequired(x => x.Tutor).WithMany(x=>x.Courses).WillCascadeOnDelete(false);
        }
    }
}