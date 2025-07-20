
using Microsoft.AspNetCore.Identity;

namespace jomasexpenssdotnetApi.Src.Domain.Models
{
    public class AppUser : IdentityUser
    {
        public AppUser()
        {
            Id = Guid.NewGuid().ToString();
            CreatedAt = DateTime.UtcNow;
            UpdatedAt = DateTime.UtcNow;
            Expenses = new  HashSet<Expense>();
        }
    
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required string Gender { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string FullName => $"{FirstName} {LastName}";
        public ICollection<Expense> Expenses { get; set; } 
      
        }
}