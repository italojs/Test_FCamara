namespace TestFCamara.Infra.Migrations
{
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<TestFCamara.Infra.Contexts.DB_FCAMARADataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(TestFCamara.Infra.Contexts.DB_FCAMARADataContext context)
        {
            
            
        }
    }
}
