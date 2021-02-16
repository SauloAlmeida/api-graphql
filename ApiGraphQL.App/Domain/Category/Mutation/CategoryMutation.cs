using ApiGraphQL.App.Infrastructure.Data.Context;
using HotChocolate;
using HotChocolate.Types;
using System.Threading;
using System.Threading.Tasks;
using static ApiGraphQL.App.Domain.Category.Mutation.Commands.CreateCommandCategory;

namespace ApiGraphQL.App.Domain.Category.Mutation
{
    [ExtendObjectType(Name = "Mutation")]
    public class CategoryMutation
    {
        public async Task<CreateCommandCategoryResponse> CreateCategoryAsync(
                   CreateCommandCategoryInput input,
                   [Service] DatabaseContext context,
                   CancellationToken ct)
        {
            var Category = new Model.Category()
            {
                Name = input.Name
            };

            await context.Categories.AddAsync(Category);

            await context.SaveChangesAsync(ct);

            return new CreateCommandCategoryResponse(Category);
        }
    }
}
