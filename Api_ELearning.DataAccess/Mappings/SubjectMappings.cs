using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Api_ELearning.DataAccess.Models;

namespace Api_ELearning.DataAccess.Mappings
{
    public class SubjectMappings : EntityTypeConfiguration<Subject>
    {
        public SubjectMappings()
        {
            // Table
            ToTable("Subjects");

            // Primary Key
            Property(x => x.Id).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            HasKey(x => x.Id);

            // Name
            Property(x => x.Name).IsRequired().HasMaxLength(255);
        }
    }
}