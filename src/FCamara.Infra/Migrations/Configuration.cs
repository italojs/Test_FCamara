namespace FCamara.Infra.Migrations
{
    using FCamaraProject.Domain.Entities;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<FCamaraProject.Infra.Contexts.FCamaraDataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(FCamaraProject.Infra.Contexts.FCamaraDataContext context)
        {
            for(int i =0; i <= 10; i++)
            {
                context.Products.Add(new Product("pipoca" + i.ToString(), i));
            }
            context.SaveChanges();
            
        }
    }
}
