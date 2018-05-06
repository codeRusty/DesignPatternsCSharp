using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    public class FacadeExibitionWrapper
    {
        public static void Execute()
        {
            string username = "username@1";
            Console.WriteLine("Enter amount that you need to withdraw");
            int amount = Convert.ToInt32(Console.ReadLine());

            BankProcessingFacade facade = new BankProcessingFacade(username);
            bool done = facade.WithdrawAmount(amount);

            if (done)
                Console.WriteLine($"{amount} withdrawan successfully");
        }

    }
}
