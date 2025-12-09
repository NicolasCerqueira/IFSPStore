using IFSPStore.Domain.Base;
using Microsoft.Extensions.Options;

namespace IFSPStore.Domain.Entities
{
    public class Sale : BaseEntity<int>
    {
        public Sale()
        {
            SaleItens = new List<SaleItem>();
        }
        public Sale(int id, DateTime saleDate, decimal saleTotal, User salesman, Customer customer) 
            : base(id)
        {
            SaleDate = saleDate;
            SaleTotal = saleTotal;
            Salesman = salesman;
            Customer = customer;
            SaleItens = new List<SaleItem>();
        }

        public DateTime SaleDate { get; set; }
        public decimal SaleTotal { get; set; }
        public int SalesmanId { get; set; } // FK para User
        public int CustomerId { get; set; } // FK para Customer
        public User Salesman { get; set; }
        public Customer Customer { get; set; }
        public List<SaleItem> SaleItens { get; set; }
    }

    public class SaleItem : BaseEntity<int>
    {
        public SaleItem()
        {
            
        }
        public SaleItem (int id, Sale? sale, Product? product, decimal quantity, 
            decimal unitPrice, decimal totalPrice) : base(id)
        {
            Sale = sale;
            Product = product;
            Quantity = quantity;
            UnitPrice = unitPrice;
            TotalPrice = totalPrice;

        }

        public int SaleId { get; set; }
        public Sale? Sale { get; set; }
        public virtual Product? Product { get; set; }
        public int ProductId { get; set; }
        public decimal Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
