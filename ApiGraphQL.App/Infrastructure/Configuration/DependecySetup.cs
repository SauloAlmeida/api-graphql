//using ApiGraphQL.App.Domain.Category.Query;
//using ApiGraphQL.App.Domain.Product.Query;
//using HotChocolate.Execution.Configuration;
//using Microsoft.Extensions.DependencyInjection;

//namespace ApiGraphQL.App.Infrastructure.Configuration
//{
//    public static class DependecySetup
//    {
//        public static void Handle(this IServiceCollection services)
//        {
//        }

//        public static void HandleGraphQL(IRequestExecutorBuilder graphService)
//        {
//            graphService.AddQueryType<ProductQuery>();
//            graphService.AddQueryType<CategoryQuery>();
//        }

//        //static void HandleType(this IServiceCollection services)
//        //{
//        //    services.AddScoped<ProductType>();
//        //    services.AddScoped<CategoryType>();
//        //}

//        //static void HandleQuery(this IServiceCollection services)
//        //{
//        //    services.AddScoped<ProductQuery>();
//        //    services.AddScoped<CategoryQuery>();
//        //}
//    }
//}
