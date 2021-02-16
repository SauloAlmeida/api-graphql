using System;

namespace ApiGraphQL.App.Domain.Product.Mutation.Commands
{
    public class CreateCommandProduct
    {
        public class CreateCommandProductInput
        {
            public CreateCommandProductInput(string name, decimal price, Guid categoryId)
            {
                Name = name;
                Price = price;
                CategoryId = categoryId;
            }

            public string Name { get; set; }
            public decimal Price { get; set; }
            public Guid CategoryId { get; set; }
        }

        public class CreateCommandProductResponse
        {
            public CreateCommandProductResponse(Model.Product product)
            {
                Product = product;
            }

            public Model.Product Product { get; set; }
        }
    }
}
