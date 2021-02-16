using ApiGraphQL.App.Domain.Category.Model;
using ApiGraphQL.App.Domain.Product.Model;
using ApiGraphQL.App.Infrastructure.Data.Context;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace ApiGraphQL.App.Infrastructure.Configuration
{
    public static class DatabaseSetup
    {
        public static void Handle(IServiceCollection services)
        {
            services.AddDbContext<DatabaseContext>(opt => opt.UseInMemoryDatabase("DatabaseContext"));
        }

        public static void InitDb(IApplicationBuilder app)
        {
            using var serviceScope = app.ApplicationServices.GetService<IServiceScopeFactory>().CreateScope();

            using var context = serviceScope.ServiceProvider.GetRequiredService<DatabaseContext>();

            if (context.Database.EnsureCreated())
            {
                var tech = new Category()
                {
                    Name = "TECH"
                };

                context.Categories.Add(tech);

                var Keyboard = new Product()
                {
                    Name = "Keyboard",
                    CategoryId = tech.Id,
                    Price = 300
                };

                var Mouse = new Product()
                {
                    Name = "Mouse",
                    CategoryId = tech.Id,
                    Price = 100
                };

                var Pc = new Product()
                {
                    Name = "Pc",
                    CategoryId = tech.Id,
                    Price = 3000
                };

                context.Products.Add(Keyboard);

                context.Products.Add(Mouse);

                context.Products.Add(Pc);

                context.SaveChanges();
            }
        }
    }
}
