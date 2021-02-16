using ApiGraphQL.App.Infrastructure.Data.Context;
using HotChocolate;
using HotChocolate.Types;
using System.Threading;
using System.Threading.Tasks;
using static ApiGraphQL.App.Domain.Product.Mutation.Commands.CreateCommandProduct;

namespace ApiGraphQL.App.Domain.Product.Mutation
{
    [ExtendObjectType(Name = "Mutation")]
    public class ProductMutation
    {
        public async Task<CreateCommandProductResponse> CreateProductAsync(
           CreateCommandProductInput input,
           [Service] DatabaseContext context,
           CancellationToken ct)
        {
            var product = new Model.Product()
            {
                Name = input.Name,
                Price = input.Price,
                CategoryId = input.CategoryId
            };

            await context.Products.AddAsync(product);

            await context.SaveChangesAsync(ct);

            return new CreateCommandProductResponse(product);
        }
    }
}
