using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    public class AdapterExibitionWrapper
    {
        public static void Execute() {

            LegacyFlightAPI api = new LegacyFlightAPI();
            api.searchFlight();
            api.BookFlight();

            Console.WriteLine("\nNow using Adapter without changing the Method in the client App. Making it change minimal\n");

            FlightAPIAdapter APIAdapter = new FlightAPIAdapter();
            APIAdapter.searchFlight();
            APIAdapter.BookFlight();

        }
    }
}
