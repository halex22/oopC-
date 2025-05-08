using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopC_
{
    internal class Transaction
    {
        public decimal Amount { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;

        public override string ToString() => $"Transaction ammount: {Amount}\ndate: {Date}";
    
    }
}
