
namespace jomasexpenssdotnetApi.Src.Domain.Models
{
    public class Expense
    {

        public Expense()
        {
            Id = Guid.NewGuid();
            CreatedAt = DateTime.UtcNow;
            UpdatedAt = DateTime.UtcNow;
        }
        // Id is the unique identifier for the expense
        public Guid Id { get; set; }

        // Title is a brief description of the expense
        public string Title { get; set; } = string.Empty;

        // Description provides details about the expense
        public string Description { get; set; } = string.Empty;

        // Amount represents the cost of the expense


        // Category is the type of expense (e.g., Travel, Food, etc.)
        public Category Category { get; set; }
        public Guid CategoryId { get; set; }

        // CreatedAt is the timestamp when the expense was created
        public DateTime CreatedAt { get; set; }
        // UpdatedAt is the timestamp when the expense was last updated
        public DateTime UpdatedAt { get; set; }

        // UserId is the identifier for the user who created the expense
        public AppUser User { get; set; }
        public string UserId { get; set; } = string.Empty;

    }
}