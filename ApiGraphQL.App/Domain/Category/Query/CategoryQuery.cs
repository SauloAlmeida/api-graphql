using ApiGraphQL.App.Infrastructure.Data.Context;
using HotChocolate;
using HotChocolate.Types;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApiGraphQL.App.Domain.Category.Query
{
    [ExtendObjectType(Name = "Query")]
    public class CategoryQuery
    {
        [UsePaging]
        [UseFiltering]
        public async Task<IList<Model.Category>> GetCategory([Service] DatabaseContext context)
        {
            return await context.Categories.AsNoTracking().Include(i => i.Products).ToListAsync();
        }
    }
}
