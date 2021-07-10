using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFApp
{
    class Flights
    {
        public int ID { get; set; }
        public int airlineID { get; set; }
        public string DepartureCity { get; set; }
        public string DepartureDate { get; set; }
        public double FlightHours { get; set; }

        public override string ToString()
        {
            var query = (from airlinedata in AirlineHelper.airlines where airlinedata.ID == airlineID select new { airlinedata.Name }).Single();
            var airlineName = query.Name;
            return airlineName;
        }
        

    }


}
