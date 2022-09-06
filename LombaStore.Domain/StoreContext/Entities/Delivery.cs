using LombaStore.Domain.StoreContext.Enums;
using System;

namespace LombaStore.Domain.StoreContext.Entities
{
    public class Delivery
    {

        public Delivery(DateTime estimateDeliveryDate)
        {
            CreateDate = DateTime.Now;
            EstimateDeliveryDate = estimateDeliveryDate;
            Status = EDeliveryStatus.Waiting;
        }
        public DateTime CreateDate {get; private set;}

        public DateTime EstimateDeliveryDate { get;  private set;}

        public EDeliveryStatus Status { get; private set; }


        public void Ship()
        {

            // Se a data de entrega estiver no passado, não entregar
            Status = EDeliveryStatus.Shipped;
        }
        
    }
}





