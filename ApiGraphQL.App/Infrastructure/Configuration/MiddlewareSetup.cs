using ApiGraphQL.App.Middleware;
using Microsoft.Extensions.DependencyInjection;

namespace ApiGraphQL.App.Infrastructure.Configuration
{
    public static class MiddlewareSetup
    {
        public static void Handle(IServiceCollection service)
        {
            service.AddMvc(options =>
            {
                options.Filters.Add<ExceptionMiddleware>();
            });
        }
    }
}
