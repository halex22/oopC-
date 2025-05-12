using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace oopC_
{
    internal class Customer: Person 
    {
        //public string? Gender { get; set; } 
        public  string Address { get; set; } 
        public string? PhoneNumber { get; set; } 
        public  string MailAddress { get; set; } 
        public PaymentMethod? PaymentMethod { get; set; }

        //public Customer() { }

        public Customer ( string name, string surname, int year, int month, int day, string mailAddress, string address) : base (name,  surname,  year,  month,  day)
        {
            MailAddress = mailAddress;
            Address = address;
        }

        public Customer(string name, string surname, DateTime dob, string mailAddress, string address) : base(name, surname, dob.Year, dob.Month, dob.Day)
        {
            MailAddress = mailAddress;
            Address = address;

        }


        public override string ToString()
        {
            return $"Custumer: {base.ToString()}";
        }

        public override string Welcome()
        {
            return "Welcome";
        }

        public virtual string PrintAddress()
        {
            return Name + " " + Surname + "\n" + MailAddress.Replace(", ", "\n");
        }

    }

    enum PaymentMethod
    {
        IBAN,
        CreditCard,
        Cash
    }
}
