

namespace jomasexpenssdotnetApi.Src.Domain.Contracts
{
 

  public class CreateExpenseRequest
    {
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public Guid CategoryId { get; set; }
    }

    /// <summary>
    /// UpdateExpenseRequest is a DTO for updating expense information.
    /// It allows partial updates to the expense's title, description, amount, date, and category ID.
    /// </summary>
    public class UpdateExpenseRequest
    {
        public string? Title { get; set; }
        public string? Description { get; set; }
        public decimal? Amount { get; set; }
        public DateTime? Date { get; set; }
        public Guid? CategoryId { get; set; }
    }

    /// <summary>
    /// ExpenseResponse is a DTO for expense information returned in API responses.
    /// It includes the expense's ID, title, description, amount, date, and category ID.
    /// </summary>
    public class ExpenseResponse
    {
        public Guid Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Amount { get; set; }
        public string UserId { get; set; } = string.Empty;
        public string UserFullName { get; set; } = string.Empty;
        public DateTime Date { get; set; }
        public Guid CategoryId { get; set; }
        public string CategoryName { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}