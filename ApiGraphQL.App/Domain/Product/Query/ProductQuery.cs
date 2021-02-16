using ApiGraphQL.App.Infrastructure.Data.Context;
using HotChocolate;
using HotChocolate.Types;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApiGraphQL.App.Domain.Product.Query
{
    [ExtendObjectType(Name = "Query")]
    public class ProductQuery
    {
        [UsePaging]
        [UseFiltering]
        public async Task<IList<Model.Product>> GetProduct([Service] DatabaseContext context)
        {
            return await context.Products.AsNoTracking().Include(i => i.Category).ToListAsync();
        }
    }
}
