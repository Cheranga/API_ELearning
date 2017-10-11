using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Api_ELearning.DataAccess.Models;

namespace Api_ELearning.DataAccess.Mappings
{
    public class StudentMappings : EntityTypeConfiguration<Student>
    {
        public StudentMappings()
        {
            // Table
            ToTable("Students");

            // Primary Key
            Property(x => x.Id).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            HasKey(x => x.Id);

            // Email
            Property(x => x.Email).IsRequired().HasMaxLength(255).IsUnicode(false);

            // Username
            Property(x => x.UserName).IsRequired().HasMaxLength(50).IsUnicode(false);

            // Password
            Property(x => x.UserName).IsRequired().HasMaxLength(255);

            // First Name
            Property(x => x.FirstName).IsRequired().HasMaxLength(50);

            // Last Name
            Property(x => x.LastName).IsRequired().HasMaxLength(50);

            // Gender
            Property(x => x.Gender).IsOptional();

            // Date of Birth
            Property(x => x.DateOfBirth).IsRequired().HasColumnType("smalldatetime");

            // Enrolled Date
            Property(x => x.EnrolledDate).IsOptional().HasColumnType("smalldatetime");

            // Last login date
            Property(x => x.LastLoginDate).IsOptional().HasColumnType("smalldatetime");
        }
    }
}