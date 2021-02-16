using ApiGraphQL.App.Domain.Category.Mutation;
using ApiGraphQL.App.Domain.Category.Query;
using ApiGraphQL.App.Domain.Product.Mutation;
using ApiGraphQL.App.Domain.Product.Query;
using GraphQL.Server.Ui.Voyager;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace ApiGraphQL.App.Infrastructure.Configuration
{
    public static class GraphQLSetup
    {
        public static void Handle(IServiceCollection service)
        {
            service
                   .AddRouting()
                   .AddGraphQLServer()
                   .AddQueryType(d => d.Name("Query"))
                       .AddTypeExtension<ProductQuery>()
                       .AddTypeExtension<CategoryQuery>()
                   .AddMutationType(d => d.Name("Mutation"))
                       .AddTypeExtension<ProductMutation>()
                       .AddTypeExtension<CategoryMutation>();
        }

        public static void HandleApp(IApplicationBuilder app)
        {
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGraphQL();
            });

            app.UseGraphQLVoyager(new GraphQLVoyagerOptions()
            {
                GraphQLEndPoint = "/graphql",
                Path = "/graphql-voyager"
            });
        }
    }
}
