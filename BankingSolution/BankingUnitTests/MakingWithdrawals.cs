using Banking.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.UnitTests
{
    public class MakingWithdrawals
    {
        [Fact]
        [InlineData(100)]
        [InlineData(50)]
        public void WithdrawalDecreasesBalance(decimal withdrawal)
        {
            var account = new BankAccount();
            var openingBalance = account.GetBalance();
            // When
            account.Withdraw(withdrawal);
            // Then
            Assert.Equal(openingBalance - withdrawal, account.GetBalance());
        }
    }
}
