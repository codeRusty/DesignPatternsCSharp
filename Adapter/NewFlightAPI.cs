using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    class NewFlightAPI
    {
        public void PayAndBook()
        {
            Console.WriteLine("Booking flight with new system");
        }

        public void CheckAvailability()
        {
            Console.WriteLine("Searching flight with new system");
        }
    }
}
