using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    public class LegacyFlightAPI : IFlightAPI
    {
        public void BookFlight()
        {
            Console.WriteLine("Booking flight with old system");
        }

        public void searchFlight()
        {
            Console.WriteLine("Searching flight with old system");
        }
    }
}
