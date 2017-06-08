using System;

namespace shop.Models
{
    public class Order
    {
        public int Id { get; private set; }
        public decimal Price { get; private set; }
        public decimal TaxRate { get; } = 0.23M;
        public decimal TotalPrice { get { return (1 + TaxRate) * Price; }}
        public bool IsPurchased { get; private set; }
        public Order(int id,decimal price)
        {
            Id = id;
            if(price <= 0)
            {
                throw new Exception("Price must be greater than 0!");
            }
            Price = price;
        }

        public void Purchase()
        {
            if(IsPurchased)
            {
                throw new Exception("Order was already purchased!");
            }
            IsPurchased = true;
        }
    }
}