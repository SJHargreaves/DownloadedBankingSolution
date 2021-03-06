using BankingDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace BankingTests.BankAccountTests
{
    public class MakingDeposits
    {
        [Fact]
        public void MakingADepositIncreasedBalance()
        {
            var account = new BankAccount(new BonusCalculatorFakeDummy());
            var openingBalance = account.GetBalance();
            var amountToDeposit = 10M;

            account.Deposit(amountToDeposit);

            Assert.Equal(openingBalance + amountToDeposit, account.GetBalance());
        }
    }
}
