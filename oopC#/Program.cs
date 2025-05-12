using System.Net.Mail;
using System.Net;
using System.Xml.Linq;

namespace oopC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dob1 = new(2000, 12, 3);
            Customer c1 = new("Pippo", "De Pipis", dob1, "Via del campo 3, 16484 Genova, Italy", "pippo@mail.com");
            c1.PaymentMethod = PaymentMethod.IBAN;
            var c2 = new Customer("Clarabella", "Molto Bella", 2001, 02, 23, "sadasd", "asdhasldh");
            var v1 = new VipCustomer("Topolino", "Mouse", 1990, 1, 30, "disney World", "mouse@gmail.com", 1000);
            var e1 = new Employee("Paperino", "De Papaeris", 1980, 3, 17, "Genova 1");
            //var p1 = new Person("Paperino", "De Papaeris", 1980, 3, 33, "Genova 1")
            //List<VipCustomer> vips = [];
            //vips.Add(v1);
            //List<Customer> normies = [];
            //normies.Add(c1);
            //normies.Add(v1);

            //foreach (var vip in normies) Console.WriteLine(vip.PrintAddress());
            SaveAccount savingAccount = new() { Customer = c1, Employee = e1 };
            savingAccount.Operate(-100);
            savingAccount.Operate(50);
            savingAccount.Operate(-10);
            savingAccount.Operate(-70);

            Console.WriteLine(savingAccount.ToString());
            Console.WriteLine($"Client balance: {savingAccount.Balance}");


        }
    }
}
