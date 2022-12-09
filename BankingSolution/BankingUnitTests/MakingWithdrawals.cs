using Banking.Domain;
using Banking.UnitTests.TestDoubles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.UnitTests
{
    public class MakingWithdrawals
    {
        [Theory]
        [InlineData(100)]
        [InlineData(50)]
        public void WithdrawalDecreasesBalance(decimal withdrawal)
        {
            var account = new BankAccount(new DummyBonusCalculator(), new Mock<INotifyAccountRep>().Object);
            var openingBalance = account.GetBalance();
            // When
            account.Withdraw(withdrawal);
            // Then
            Assert.Equal(openingBalance - withdrawal, account.GetBalance());
        }
    }
}
