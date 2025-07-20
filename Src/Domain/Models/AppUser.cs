
using Microsoft.AspNetCore.Identity;

namespace jomasexpenssdotnetApi.Src.Domain.Models
{
    public class AppUser : IdentityUser
    {
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required string Gender { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
        public string FullName => $"{FirstName} {LastName}";
        public ICollection<Expense> Expenses { get; set; } = new List<Expense>();
      
        }
}