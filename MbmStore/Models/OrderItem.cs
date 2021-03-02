using System;
namespace MbmStore.Models
{
    public class OrderItem
    {

        public int OrderItemId { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice
        {
            get
            {
                decimal total = Product.Price * Quantity;
                return total;
            }
        }

        public OrderItem(Product product, int quantity)
        {
            this.Product = product;
            this.Quantity = quantity;
        }
    }
}
