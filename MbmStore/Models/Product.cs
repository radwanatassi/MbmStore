using System;
namespace MbmStore.Models
{
    public class Product
    {
        public string Title { get; set; }
        public decimal Price { get; set; }
        public string ImageFileName { get; set; }


        public Product()
        {


        }

        public Product(string title, decimal price)
        {
            this.Title = title;
            this.Price = price;


        }
    }
}

