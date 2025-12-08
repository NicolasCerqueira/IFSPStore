using IFSPStore.Domain.Base;

namespace IFSPStore.Domain.Entities
{
    public  class Product : BaseEntity<int>
    {
        public Product()
        {
            
        }
        public Product(int id, string name, decimal price, decimal quantity, DateTime purchaseDate, 
            string salesUnit, Category category) : base(id)
        {
            Name = name;
            Price = price; //preco
            Quantity = quantity; //quantidade
            PurchaseDate = purchaseDate; //data da compra
            SalesUnit = salesUnit; //unidade vendida
            Category = category;
        }

        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal Quantity { get; set; }
        public DateTime PurchaseDate { get; set; }
        public string SalesUnit { get; set; }
        public int CategoryId { get; set; }
        public Category? Category { get; set; }
    }
}