using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopC_
{
    internal class VipCustomer: Customer
    {


        private string? namePrefix {  get; set; }
        private decimal negativeThreshold { get; set; }

        public VipCustomer(string name, string surname, DateTime dob, string address, string mailAddress, decimal threshold) : base(name, surname, dob, address, mailAddress)
        {
            namePrefix = "sua eccelenza";
            negativeThreshold = threshold;
        }

        public VipCustomer(string name, string surname, int year, int month, int day, string address, string mailAddress, decimal threshold) : base(name, surname, year, month, day, address, mailAddress)
        {
            namePrefix = "sua eccelenza";
            negativeThreshold = threshold;
        }

        public override string ToString() => $"{namePrefix} {base.ToString()}";

        public override string Welcome() => $"{base.Welcome()} {namePrefix}";

        public override string PrintAddress()
        {
            return namePrefix + " " + base.PrintAddress();
        }
    }
}
