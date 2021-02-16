using ApiGraphQL.App.Domain.Core.Model;
using System.Collections.Generic;

namespace ApiGraphQL.App.Domain.Category.Model
{
    public class Category : Entity
    {
        public string Name { get; set; }

        public ICollection<Product.Model.Product> Products { get; set; } = new List<Product.Model.Product>();
    }
}
