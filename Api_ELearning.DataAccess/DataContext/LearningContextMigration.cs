using System.Data.Entity.Migrations;

namespace Api_ELearning.DataAccess.DataContext
{
    public class LearningContextMigration : DbMigrationsConfiguration<LearningContext>
    {
        public LearningContextMigration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(LearningContext context)
        {
            var dataSeeder = new DataSeeder(context);
            dataSeeder.Seed();
        }
    }
}