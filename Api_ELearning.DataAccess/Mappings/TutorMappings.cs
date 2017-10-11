using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Api_ELearning.DataAccess.Models;

namespace Api_ELearning.DataAccess.Mappings
{
    public class TutorMappings : EntityTypeConfiguration<Tutor>
    {
        public TutorMappings()
        {
            // Table
            ToTable("Tutors");

            // Primary Key
            Property(x => x.Id).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            HasKey(x => x.Id);

            // Email
            Property(x => x.Email).IsRequired().HasMaxLength(255).IsUnicode(false);

            // Username
            Property(x => x.UserName).IsRequired().HasMaxLength(50).IsUnicode(false);

            // Password
            Property(x => x.Password).IsRequired().HasMaxLength(255);

            // First Name
            Property(x => x.FirstName).IsRequired().HasMaxLength(50);

            // Last Name
            Property(x => x.LastName).IsRequired().HasMaxLength(50);

            // Gender
            Property(x => x.Gender).IsOptional();
        }
    }
}