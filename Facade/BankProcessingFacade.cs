using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    internal class BankProcessingFacade
    {
        AccountService accountService;
        LoanService loanService;

        // Uses multiple services / object to make this processing successfull
        internal BankProcessingFacade(string username)
        {
            accountService = new AccountService(username);
            loanService = new LoanService(username);
        }

        internal bool WithdrawAmount(int amount)
        {
            try
            {
                bool isValidRequest = true;
                if (!loanService.checkAllLoanPremiumClear())
                {
                    isValidRequest = false;
                }
                if (!accountService.IsBalanceAvailable(amount))
                {
                    isValidRequest = false;
                }
                if (isValidRequest)
                {
                    // Can be any other service to deduct amount
                    accountService.WithdrawAmount(amount);
                }
                return isValidRequest;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }

        }
    }
}
