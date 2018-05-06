using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SingletonProj
{
   public sealed class NotSingleton
    {
        private static NotSingleton instance = null;
        private static readonly object padlock = new object();
        private int AccountValue = 500;

        public NotSingleton()
        {
        }

        public int ReduceAmount(int amount)
        {
            int balance = AccountValue - amount;
            AccountValue -= amount;
            return balance;
            
        }
    }
}
