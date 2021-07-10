using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFApp
{
    class Passenger
    {
        public int ID { get; set; }
        public int customerID { get; set; }
        public int flightID { get; set; }

        public override string ToString()
        {
            var query1 = (from flightdata in FlightHelper.flights where flightdata.ID == flightID select new { flightdata.DepartureCity }).Single();
            var query2 = (from customerdata in CustomerHelper.customers where customerdata.ID == customerID select new { customerdata.Name }).Single();
            var output =  query2.Name + " departuring from " + query1.DepartureCity;
            return output;
        }
    }
}
