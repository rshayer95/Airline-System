using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFApp
{
    class passengerHelper
    {
        public static List<Passenger> passengers = new List<Passenger>();
        // PASSENGER ID GENERATOR
        public static int PassengerID_generator(int id)
        {
            return id + 1;
        }
        //Check if Passenger exists
        public static bool findPassengerByID(int id)
        {
            var resultSet = from passengerdata in passengers where passengerdata.ID == id select passengerdata;
            //If ResultSet has data, Employee exists
            if (resultSet.Count() > 0)
            {
                return true;
            }
            return false;
        }
        //Check if Flight exists
        public static bool findFlightByID(int id)
        {
            var resultSet = from flightdata in FlightHelper.flights where flightdata.ID == id select flightdata;
            //If ResultSet has data, Employee exists
            if (resultSet.Count() > 0)
            {
                return true;
            }
            return false;
        }
        //Check if Customer exists
        public static bool findCustomerByID(int id)
        {
            var resultSet = from customerdata in CustomerHelper.customers where customerdata.ID == id select customerdata;
            //If ResultSet has data, Employee exists
            if (resultSet.Count() > 0)
            {
                return true;
            }
            return false;
        }
        // Add Passenger to the Passenger List
        public static bool AddPassenger(Passenger data)
        {
            if (findPassengerByID(data.ID))
            {
                var id = data.ID;
                data.ID = PassengerID_generator(id);
            }
            if(!findCustomerByID(data.customerID) || !findFlightByID(data.flightID))
            {
                return false;
            }
            
            passengers.Add(data);
            return true;
                
            
        }
        // UPDATE THE PASSENGER
        public static bool UpdatePassenger(Passenger data)
        {
            if (findPassengerByID(data.ID) && findFlightByID(data.flightID) && findCustomerByID(data.customerID))
            {
                var PL = from e in passengers where e.ID == data.ID select e;
                foreach (var passenger in PL)
                {
                    passenger.ID = data.ID;
                    passenger.customerID = data.customerID;
                    passenger.flightID = data.flightID;
                    }
                return true;
            }

            return false;
        }
        //Delete Flight
        public static void deletePassenger(int ID)
        {
            passengers = passengers.Except(from c in passengers where c.ID == ID select c).ToList();
        }
        //Populate Flights List With Pre-defined Data
        public static void populatePassengerData()
        {
            AddPassenger(new Passenger { ID = 1, customerID = 1, flightID = 2});
            AddPassenger(new Passenger { ID = 2, customerID = 2, flightID = 2 });
            AddPassenger(new Passenger { ID = 3, customerID = 3, flightID = 1 });
            AddPassenger(new Passenger { ID = 4, customerID = 4, flightID = 1 });
            AddPassenger(new Passenger { ID = 5, customerID = 5, flightID = 3 });
        }
    }
}
