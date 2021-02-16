namespace ApiGraphQL.App.Domain.Category.Mutation.Commands
{
    public class CreateCommandCategory
    {
        public class CreateCommandCategoryInput
        {
            public CreateCommandCategoryInput(string name)
            {
                Name = name;
            }

            public string Name { get; set; }
        }

        public class CreateCommandCategoryResponse
        {
            public CreateCommandCategoryResponse(Model.Category category)
            {
                Category = category;
            }

            public Model.Category Category { get; set; }
        }

    }
}
