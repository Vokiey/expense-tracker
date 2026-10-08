using System;
using System.Collections.Generic;
using System.Text;

namespace Tracker.Domain.Tests
{
    public class AccountTests
    {
        [Fact]
        public void Deposit_IncreaseBalace()
        {
            Account account = new Account();
            account.Deposit(100m);


            Assert.Equal(100m, account.Balance);
        }

    }
}
