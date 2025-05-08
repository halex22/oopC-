using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopC_
{
    internal abstract class BaseAccount
    {
        public required Employee Employee { get; set; }
        public required Customer Customer { get; set; }
        public DateTime CreationDate { get; set; } = DateTime.Now;
        public decimal WithdrawModifier { get; set; }
        public decimal DepositModifier { get; set; }
        public List<Transaction> Transactions { get; set; } = [];

        public decimal Balance => Transactions.Aggregate(0m, (t, n) =>
            n.Amount > 0 
                ? t + (n.Amount + (n.Amount * DepositModifier))
                : t + ( n.Amount - (Math.Abs(n.Amount) * WithdrawModifier)));

        public bool CanTransactionProceed(decimal amount) 
        {
            if (amount < 0 && Balance <= 0) return false;

            if (amount < 0 && (Balance -  amount) <= 0) return false;

            return true;
        }

        public void Operate(decimal transactionAmount)
        {
            if (!CanTransactionProceed(transactionAmount))
            {
                LogErroMessage();
                return;
            }

            Transaction t = new() { Amount = transactionAmount };
            Transactions.Add(t);

            LogSuccessMessage();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Owner: {Customer.Name}\nReferent: {Employee.Name}");
            sb.AppendLine($"Creation Date: {CreationDate.ToString()}");
            sb.AppendLine($"Transactions:\n {Transactions.Aggregate("", (t, n) => t + $"\n{n}")}\n");
            return sb.ToString();
        }

        public void LogSuccessMessage()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Transaction completed successfully!");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void LogErroMessage()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Not enough balance to proceed");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
