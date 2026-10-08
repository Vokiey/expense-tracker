using System;
using System.Collections.Generic;
using System.Text;

namespace Tracker.Domain
{
    public class Account
    {
        public decimal Balance {  get; private set; }

        public void Deposit(decimal amount) => Balance += amount; 

    }
}
