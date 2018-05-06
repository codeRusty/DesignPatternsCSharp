using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    class FlightAPIAdapter : IFlightAPI
    {
        NewFlightAPI flightAPI = new NewFlightAPI();
        public void BookFlight()
        {
            flightAPI.PayAndBook();
        }

        public void searchFlight()
        {
            flightAPI.CheckAvailability();
        }
    }
}
