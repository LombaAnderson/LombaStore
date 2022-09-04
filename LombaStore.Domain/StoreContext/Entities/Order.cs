using LombaStore.Domain.StoreContext.Enums;
using System;

namespace LombaStore.Domain.StoreContext.Entities
{
    public class Order
    {
        public Order(Customer customer)
        {
            Customer = customer;
            Number = Guid.NewGuid().ToString().Replace("-", "").Substring(0, 8).ToUpper();
            CreateDate = DateTime.Now;
            Status = EOrderStatus.Created;
            Items = new List<OrderItem>();
            Deliveries = new List<Delivery>();
                
        }
        public Customer Customer { get; private set; }
        public string Number {get;  private set;}

        public DateTime CreateDate { get;  private set; }

        public EOrderStatus Status { get;  private set; }

        public IReadOnlyCollection<OrderItem> Items { get;  private set; }

        public IReadOnlyCollection<Delivery> Deliveries { get;  private set; }

        public void AddItem(OrderItem item)
        {
            // Valida item
           // Adiciona ao pedido
        }

        // To Place An Order

        public void Place(){}
        
    }
}