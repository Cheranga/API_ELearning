using System.Data.Entity;
using System.Data.Entity.Core.Common.CommandTrees;
using Api_ELearning.DataAccess.Mappings;
using Api_ELearning.DataAccess.Models;

namespace Api_ELearning.DataAccess.DataContext
{
    public class LearningContext : DbContext
    {
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Tutor> Tutors { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }

        public LearningContext() : base("name=eLearning")
        {
            Configuration.ProxyCreationEnabled = false;
            Configuration.LazyLoadingEnabled = false;

            Database.SetInitializer(new MigrateDatabaseToLatestVersion<LearningContext, LearningContextMigration>());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new SubjectMappings());
            modelBuilder.Configurations.Add(new CourseMappings());
            modelBuilder.Configurations.Add(new TutorMappings());
            modelBuilder.Configurations.Add(new StudentMappings());
            modelBuilder.Configurations.Add(new EnrollmentMappings());

            base.OnModelCreating(modelBuilder);
        }

        
    }
}