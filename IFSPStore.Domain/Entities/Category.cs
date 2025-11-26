using IFSPStore.Domain.Base;

namespace IFSPStore.Domain.Entities
{
    public class Category : BaseEntity<int>
    {
        public Category()
        {
            
        }
        public Category(string name, string description) : base()
        {
            Name = name;
            Description = description;
        }
        public string? Name { get; set; }
        public string? Description { get; set; }
    }
}
