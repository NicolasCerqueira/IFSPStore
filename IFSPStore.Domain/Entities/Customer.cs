using IFSPStore.Domain.Base;

namespace IFSPStore.Domain.Entities
{
    public class Customer : BaseEntity<int>
    {
        public Customer()
        {
            
        }
        public Customer(int id, string name, string address, string documentId, string district, 
            City city) : base(id)
        {
            Nome = name;
            Address = address;
            DocumentId = documentId;
            District = district;
            City = city;
        }

        public string? Nome { get; set; }
        public string? Address { get; set; }
        public string? DocumentId { get; set; }
        public string? District { get; set; }
        public int CityId { get; set; }
        public City? City { get; set; } //relacionamento

    }
}
