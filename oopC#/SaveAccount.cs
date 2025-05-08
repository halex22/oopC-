using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopC_
{
    internal class SaveAccount: BaseAccount
    {
        public SaveAccount()
        {
            WithdrawModifier = 0.03m;
            DepositModifier = 0.02m;

        }

    }
}
