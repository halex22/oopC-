using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopC_
{
    internal class CashbackAccount: BaseAccount
    {
        public CashbackAccount()
        {
            WithdrawModifier = 0.05m;
            DepositModifier = 0m;
        }

    }
}
