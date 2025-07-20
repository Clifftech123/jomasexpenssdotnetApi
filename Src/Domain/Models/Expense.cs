
namespace jomasexpenssdotnetApi.Src.Domain.Models
{
    public class Expense
    {
        // Id is a unique identifier for each expense
        public Guid Id { get; set; } = Guid.NewGuid();

        // Title is a brief description of the expense
        public string Title { get; set; } = string.Empty;

        // Description provides details about the expense
        public string Description { get; set; } = string.Empty;

        // Amount represents the cost of the expense
        public decimal Amount { get; set; }

        // Date is when the expense was incurred
        public DateTime Date { get; set; } = DateTime.UtcNow;

        // Category is the type of expense (e.g., Travel, Food, etc.)
        public Category Category { get; set; }
        public Guid CategoryId { get; set; }

        // CreatedAt is the timestamp when the expense was created
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        // UpdatedAt is the timestamp when the expense was last updated
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

        // UserId is the identifier for the user who created the expense
        public AppUser User { get; set; }
        public string UserId { get; set; } = string.Empty;

    }
}