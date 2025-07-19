

using System.Collections.ObjectModel;

namespace jomasexpenssdotnetApi.Src.Domain.Models
{
    public class Category
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public Collection<Expense> Expenses { get; set; } = new Collection<Expense>();

    }
}