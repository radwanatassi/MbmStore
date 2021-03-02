using System;
using System.Collections.Generic;
namespace MbmStore.Models
{
    public class Invoice
    {
        private decimal totalPrice;

        public int InvoiceId { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalPrice
        { get
            {
                return totalPrice; } }

        public Customer Customer { get; set; }
        public List<OrderItem> OrderItems { get;} = new List<OrderItem>();

        public Invoice()
        {
        }

        public Invoice(int invoiceId, DateTime orderDate, Customer customer)
        {
            this.InvoiceId = invoiceId;
            this.OrderDate = orderDate;
            this.Customer = customer;
        }

        public void AddOrderItem (Product product, int quantity)
        {
            var orderItem = new OrderItem(product, quantity);
            this.OrderItems.Add(orderItem);

            decimal orderAmount = product.Price * quantity;
            totalPrice += orderAmount;
        }

        
    }
}
