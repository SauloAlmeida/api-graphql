using ApiGraphQL.App.Domain.Core.Model;
using System;

namespace ApiGraphQL.App.Domain.Product.Model
{
    public class Product : Entity
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public Guid CategoryId { get; set; }

        public Category.Model.Category Category { get; set; }
    }
}
