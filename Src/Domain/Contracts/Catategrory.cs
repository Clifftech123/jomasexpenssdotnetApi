

namespace jomasexpenssdotnetApi.Src.Domain.Contracts
{


    // Category DTO for data transfer
    public class CreateCategoryRequest
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
    }

    /// <summary>
    ///  UpdateCategoryRequest is a DTO for updating category information
    /// It allows partial updates to the category's name and description.
    /// </summary>
    public class UpdateCategoryRequest
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
    }

    /// <summary>
    /// CategoryResponse is a DTO for category information returned in API responses
    /// It includes the category's ID, name, and description.
    /// </summary>
    public class CategoryResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
    }

    /// <summary>
    /// CategoryWithExpensesResponse is a DTO for category information along with its expenses
    /// It includes the category's ID, name, description, and a collection of expenses.
    /// </summary>
    public class CategoryWithExpensesResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public ICollection<ExpenseResponse> Expenses { get; set; } = new List<ExpenseResponse>();
    }
}