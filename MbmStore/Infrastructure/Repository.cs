using System;
using System.Collections.Generic;
using MbmStore.Models;
namespace MbmStore.Infrastructure
{
    public static class Repository
    {
        public static List<Customer> Customers { get; set; } = new List<Customer>();
        public static List<Product> Products = new List<Product>();
        public static List<Invoice> Invoices = new List<Invoice>();

        static Repository()
        {
            // Book Mockups Objects
            var book1 = new Book("Cal Newport", "Deep Work", 150.00m, "Improvement Zone");
            book1.ImageFileName = "Deep_Work.jpg";
            book1.ISBN = "978-0-349-41190-3";

            // Add to the product list
            Products.Add(book1);

            var book2 = new Book("David Schwartz", "The Magic Of Thinking Big", 160.00m, "Vermillion");
            book2.ImageFileName = "The_Magic.jpeg";
            book2.ISBN = "978-1-78504-047-4";
            Products.Add(book2);

            var book3 = new Book("Yuval Noah Harari", "Sapiens", 175.00m, "Harper Perennial");
            book3.ImageFileName = "Sapiens.jpeg";
            book3.ISBN = "978-0-06-231611-0";
            Products.Add(book3);

            // MusicCD Mockups Objects

            var cd1 = new MusicCD("Ed Sheeran", "Delux", 128.00m, 2017);
            cd1.AddTrack(new Track("Eraser", new TimeSpan(0, 6, 40)));
            cd1.AddTrack(new Track("Castle on the Hill", new TimeSpan(0, 10, 40)));
            cd1.AddTrack(new Track("Dive", new TimeSpan(0, 6, 40)));
            cd1.AddTrack(new Track("Shape of You", new TimeSpan(0, 5, 20)));
            cd1.AddTrack(new Track("Galway Girl", new TimeSpan(0, 12, 40)));
            cd1.AddTrack(new Track("New Man", new TimeSpan(0, 4, 50)));
            cd1.ImageFileName = "Delux.png";
            Products.Add(cd1);

            var cd2 = new MusicCD("Jahnavi Harrison", "Rise", 123.00m, 2020);
            cd2.AddTrack(new Track("Rise", new TimeSpan(0, 6, 40)));
            cd2.AddTrack(new Track("Gajendra", new TimeSpan(0, 6, 40)));
            cd2.AddTrack(new Track("Adore", new TimeSpan(0, 3, 40)));
            cd2.AddTrack(new Track("Born to Give", new TimeSpan(0, 8, 40)));
            cd2.AddTrack(new Track("Brhamas Song", new TimeSpan(0, 10, 40)));
            cd2.AddTrack(new Track("Eraser", new TimeSpan(0, 4, 40)));
            cd2.AddTrack(new Track("Kairavs", new TimeSpan(0, 17, 40)));
            cd2.ImageFileName = "Rise.jpg";
            Products.Add(cd2);

            var cd3 = new MusicCD("Kina", "Wish I Was", 115.00m, 2020);

            cd3.AddTrack(new Track("Wish I could", new TimeSpan(0, 6, 40)));
            cd3.AddTrack(new Track("Never Again", new TimeSpan(0, 8, 40)));
            cd3.AddTrack(new Track("The Moon", new TimeSpan(0, 12, 40)));
            cd3.AddTrack(new Track("Sun is going down", new TimeSpan(0, 19, 40)));
            cd3.AddTrack(new Track("Sun is going up", new TimeSpan(0, 4, 40)));
            cd3.AddTrack(new Track("Sky is Blue", new TimeSpan(0, 3, 40)));
            cd3.ImageFileName = "Kina.jpg";
            Products.Add(cd3);

            // Movie Mockup Objects
            var movie1 = new Movie("Jungle Book", 160.50m, "junglebook.jpg", "Jon Favreu");
            Products.Add(movie1);

            var movie2 = new Movie("Gladiator", 171.50m, "gladiator.jpg", "Ridley Scott");
            Products.Add(movie2);

            var movie3 = new Movie("Forrest Gump", 140.20m, "forrest-gump.jpg", "Mark Potter");
            Products.Add(movie3);


            // Customers Mockup Mockup
            Customer customer1 = new Customer(1,"Mike", "Larsen", "Skolegade 15", "8200", "Aarhus");
            customer1.AddPhone("42220327");
            customer1.SetBirthDate("01-02-1990");

            Customer customer2 = new Customer(2,"John", "Johansen", "Storegade 3", "8200", "Aarhus");
            customer2.AddPhone("42220327");
            customer2.SetBirthDate("01-02-1990");

            Customer customer3 = new Customer(3,"Mette", "Harrison", "Landevej 9", "8200", "Aarhus");
            customer3.AddPhone("42220327");
            customer3.SetBirthDate("01-02-1990");

            Customer customer4 = new Customer(4,"Mia", "Horsholm", "Sydvej 5", "8200", "Aarhus");
            customer4.AddPhone("42220327");
            customer4.SetBirthDate("01-02-1990");

            Customer customer5 = new Customer(5, "John", "Mike", "Storegade 15", "6000", "Aarhus");
            customer5.AddPhone("42220327");
            customer5.SetBirthDate("01-02-1990");

            Customer customer6 = new Customer(6, "Christian", "Christansen", "Nørregade 12", "6100", "Viby");
            customer6.AddPhone("52117975");
            customer6.AddPhone("20203025");
            customer6.SetBirthDate("11-03-1980");

            Customer customer7 = new Customer(7, "Mette", "Larsen", "Skolegade 28", "6200", "Brabrand");
            customer7.AddPhone("3201254");
            customer7.SetBirthDate("3-21-1975");

            // Add to the Customers list
            Customers.Add(customer1);
            Customers.Add(customer2);
            Customers.Add(customer3);
            Customers.Add(customer4);
            Customers.Add(customer5);
            Customers.Add(customer6);
            Customers.Add(customer7);

            // Invoices Mockups

            Invoice invoice1 = new Invoice(1, DateTime.Now, customer1);
            Invoice invoice2 = new Invoice(2, DateTime.Now, customer2);
            Invoice invoice3 = new Invoice(3, DateTime.Now, customer3);
            Invoice invoice4 = new Invoice(4, DateTime.Now, customer4);

            customer1.AddInvoice(invoice1);
            customer1.AddInvoice(invoice4);

            customer2.AddInvoice(invoice2);
            customer3.AddInvoice(invoice3);

            // Add OrderItems to the invoice
            invoice1.AddOrderItem(movie1,1);
            invoice1.AddOrderItem(book2, 2);

            invoice2.AddOrderItem(cd2, 2);
            invoice2.AddOrderItem(book3, 1);

            invoice3.AddOrderItem(movie2, 1);
            invoice3.AddOrderItem(cd3, 1);

            invoice4.AddOrderItem(movie3, 1);
            invoice4.AddOrderItem(book1, 3);

            // Add to Invoices list
            Invoices.Add(invoice1);
            Invoices.Add(invoice2);
            Invoices.Add(invoice3);
            Invoices.Add(invoice4);





        }
    }
}
