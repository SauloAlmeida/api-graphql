using ApiGraphQL.App.Infrastructure.Configuration;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace ApiGraphQL
{
    public class Startup
    {
        public Startup(IConfiguration configuration) => Configuration = configuration;

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            DatabaseSetup.Handle(services);

            GraphQLSetup.Handle(services);

            MiddlewareSetup.Handle(services);     
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment()) {

                app.UseDeveloperExceptionPage();

                DatabaseSetup.InitDb(app);
            };

            app.UseCors(App.Infrastructure.Constant.Startup.AllowedOrigin);

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            GraphQLSetup.HandleApp(app);
        }
    }
}
