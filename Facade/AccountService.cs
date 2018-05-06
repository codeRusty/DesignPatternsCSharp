using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    class AccountService
    {
        private string _username;
        Dictionary<string, int> accounts = new Dictionary<string, int>(){
            { "username@1",50000 }
        };

        internal AccountService(string username)
        {
            _username = username;
        }


        public bool IsBalanceAvailable(int amount)
        {
            int AccountBalance;
            bool isAccountAvailable = accounts.TryGetValue(_username, out AccountBalance);
            if (isAccountAvailable)
            {
                if (AccountBalance > amount)
                    return true;
                else
                    throw new Exception("Account Balance Low");
            }
            else
            {
                throw new Exception("No account found with the username");
            }

        }
        internal void WithdrawAmount(int amount)
        {
            Console.WriteLine($"Withdrawing amount: {amount}");
        }
    }
}
