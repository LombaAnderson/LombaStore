using FluentValidator;

namespace LombaStore.Domain.StoreContext.Entities
{
    public class Product: Notifiable
    {
        public Product(
            string title,
            string description,
            string image,
            decimal price,
            decimal quantity)
        {
            Title = title;
            Description = description;
            Image = image;
            Price = price;
            QuantityOnHand = quantity;

            
        }

        public string Title { get;  private set; }

        public string  Description { get;  private set; }

        public string Image { get; set; }

        public decimal Price { get; set; }

        public decimal QuantityOnHand { get; set; }

        
        public override string ToString()
        {
            return Title;
        }       
    }
}