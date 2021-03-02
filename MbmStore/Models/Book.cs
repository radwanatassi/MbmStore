using System;
namespace MbmStore.Models
{
    public class Book : Product
    {
        public string Author { get; set; }
        public string Publisher { get; set; }
        public short Published { get; set; }
        public string ISBN { get; set; }


        public Book()
        {

        }

        public Book(string author, string title, decimal price, string publisher) : base (title, price)
        {
            this.Author = author;
            this.Publisher = publisher;
        }


    }
}
    


