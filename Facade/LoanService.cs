using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    class LoanService
    {
        private string _username;
        Dictionary<string, int> loanAccounts = new Dictionary<string, int>(){
            { "username@1",0 }
        };

        internal LoanService(string username)
        {
            _username = username;
        }

        public bool checkAllLoanPremiumClear() {
            int LoanAccountBalance;

            bool isAccountAvailable = loanAccounts.TryGetValue(_username, out LoanAccountBalance);

            if (isAccountAvailable)
            {
                if (LoanAccountBalance <= 0)
                    return true;
                else
                    throw new Exception("Loan Premium Pending");
            }
            else
            {
                throw new Exception("No account found with the username");
            }
        }

    }
}
