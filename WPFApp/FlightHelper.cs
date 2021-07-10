using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFApp
{
    class FlightHelper
    {
        public static List<Flights> flights = new List<Flights>();
        // Flight ID GENERATOR
        public static int FlightID_generator(int id)
        {
            return id + 1;
        }
        //Check if Flight exists
        public static bool findFlightByID(int id)
        {
            var resultSet = from flightdata in flights where flightdata.ID == id select flightdata;
            //If ResultSet has data, Employee exists
            if (resultSet.Count() > 0)
            {
                return true;
            }
            return false;
        }
        //Check if Airline exists
        public static bool findAirlineByID(int id)
        {
            var resultSet = from airlinedata in AirlineHelper.airlines where airlinedata.ID == id select airlinedata;
            //If ResultSet has data, Employee exists
            if (resultSet.Count() > 0)
            {
                return true;
            }
            return false;
        }
        // Add Flight to the Flight List
        public static bool AddFlight(Flights data)
        {
            int OldCount = flights.Count();
            if (findFlightByID(data.ID))
            {
                var id = data.ID;
                data.ID = FlightID_generator(id);
            }
            if (findAirlineByID(data.airlineID))
            {
                flights.Add(data);
                int newCount = flights.Count();
                if (newCount > OldCount)
                {
                    return true;
                }
            }
            
            return false;
        }
        // UPDATE THE Flight
        public static bool UpdateFlight(Flights data)
        {
            if (findFlightByID(data.ID) && findAirlineByID(data.airlineID))
            {
                var FL = from e in flights where e.ID == data.ID select e;
                foreach (var flight in FL)
                {
                    flight.ID = data.ID;
                    flight.airlineID = data.airlineID;
                    flight.DepartureCity = data.DepartureCity;
                    flight.DepartureDate = data.DepartureDate;
                    flight.FlightHours = data.FlightHours;
                }
                return true;
            }

            return false;
        }
        //Delete Flight
        public static void deleteFlight(int flightID)
        {
            flights = flights.Except(from c in flights where c.ID == flightID select c).ToList();
        }
        //Populate Flights List With Pre-defined Data
        public static void populateFlightData()
        {
            AddFlight(new Flights { ID = 1, airlineID = 1, DepartureCity = "Toronto", DepartureDate = "27/June/2020", FlightHours = 23 });
            AddFlight(new Flights { ID = 2, airlineID = 2, DepartureCity = "Delhi", DepartureDate = "22/June/2020", FlightHours = 23 });
            AddFlight(new Flights { ID = 3, airlineID = 2, DepartureCity = "Mumbai", DepartureDate = "19/June/2020", FlightHours = 23 });
            AddFlight(new Flights { ID = 4, airlineID = 3, DepartureCity = "Amritsar", DepartureDate = "25/June/2020", FlightHours = 23 });
            AddFlight(new Flights { ID = 5, airlineID = 1, DepartureCity = "Toronto", DepartureDate = "30/June/2020", FlightHours = 23 });
            
        }
    }
}
