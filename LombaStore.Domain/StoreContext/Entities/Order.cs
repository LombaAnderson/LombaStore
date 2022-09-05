using LombaStore.Domain.StoreContext.Enums;
using System;

namespace LombaStore.Domain.StoreContext.Entities
{
    public class Order
    {

        private readonly IList<OrderItem> _items;
        private readonly IList<Delivery> _deliveries;
        public Order(Customer customer)
        {
            Customer = customer;
            Number = Guid.NewGuid().ToString().Replace("-", "").Substring(0, 8).ToUpper();
            CreateDate = DateTime.Now;
            Status = EOrderStatus.Created;
            _items = new List<OrderItem>();
            _deliveries = new List<Delivery>();
                
        }
        public Customer Customer { get; private set; }
        public string Number {get;  private set;}

        public DateTime CreateDate { get;  private set; }

        public EOrderStatus Status { get;  private set; }

        public IReadOnlyCollection<OrderItem> Items => _items.ToArray();

        public IReadOnlyCollection<Delivery> Deliveries => _deliveries.ToArray();

        public void AddItem(OrderItem item)
        {
            // Valida item
            // Adiciona ao pedido
            _items.Add(item);
        }

        public void AddDelivery(Delivery delivery)
        {
            _deliveries.Add(delivery);
        }


        // To Place An Order
        public void Place(){}
        
    }
}