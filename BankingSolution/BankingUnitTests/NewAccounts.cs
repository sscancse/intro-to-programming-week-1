using Banking.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.UnitTests
{
    public class NewAccounts
    {
        public void CorrectOpeningBalance()
        {
            // Write the code you wish you had
            // Given
            var account = new BankAccount();
            // When
            decimal balance = account.GetBalance();
            // Then 
            Assert.Equal(5000M, balance);
        }
    }
}
