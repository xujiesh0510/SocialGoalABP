using System.Data.Entity.Migrations;

namespace SocialGoal.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<SocialGoal.EntityFramework.SocialGoalDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "SocialGoal";
        }

        protected override void Seed(SocialGoal.EntityFramework.SocialGoalDbContext context)
        {
            // This method will be called every time after migrating to the latest version.
            // You can add any seed data here...
        }
    }
}
