using System;
using System.Collections;
using System.Collections.Generic;

namespace MbmStore.Models
{
    public class Customer
    {
        private DateTime birthDate;

        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Zip { get; set; }
        public string City { get; set; }

        public List<string> PhoneNumbers { get; } = new List<string>();
        public DateTime BirthDate {
            set
            {
                birthDate = value;
                
            }
            get { return birthDate; } }


        public int Age {
            get
            {
                DateTime now = DateTime.Now;
                int age;

                age = now.Year - birthDate.Year;

                if (now.Month < birthDate.Month ||
                (now.Month == birthDate.Month && now.Day < birthDate.Day))
                {
                    age--;
                }

                // Validate the age
                if (age > 0 && age < 121)
                {
                    return age;

                }
                else
                {
                    throw new Exception("Age Not Valid");
                }

            }  }

        public List<Invoice> Invoices { get; set; } = new List<Invoice>();


        public Customer()
        {
            

        }

        public Customer(int customerId, string firstName, string lastName, string address, string zip, string city)
        {
            this.CustomerId = customerId;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Address = address;
            this.Zip = zip;
            this.City = city;

        }

        public void AddPhone (string phone)
        {
            PhoneNumbers.Add(phone);
        }

        public void AddInvoice (Invoice invoice)
        {
            Invoices.Add(invoice);
        }

        // Helper to parse string to DateTime

        public void SetBirthDate (string birthDate)
        {
            var parsedDate = DateTime.Parse(birthDate);
            this.BirthDate = parsedDate.Date;
        }
    }
}
