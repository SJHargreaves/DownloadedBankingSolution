using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace BankingTests.BankingAccountTests
{
    public class MakingDeposits
    {

        [Fact]
        public void MakingADepositIncreasedBalance()
        {
            var account = new BankAccount();
            var openingBalance = account.GetBalance();
            var amountToDeposit = 10M;

            account.Deposit(amountToDeposit);

            public void Deposit(decimal amountToDeposit)
            {
                _balance += amountToDeposit;
            }

        }
    }
}
