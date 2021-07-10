using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFApp
{
    class AirlineHelper
    {
        public static List<Airline> airlines = new List<Airline>();
        public static string selectedMeal;
        public static string selectedAirplane;
        // AIRLINE ID GENERATOR
        public static int AirlineID_generator(int id)
        {
            return id + 1;
        }
        //Check if Airline exists
        public static bool findAirlineByID(int id)
        {
            var resultSet = from airlinedata in airlines where airlinedata.ID == id select airlinedata;
            //If ResultSet has data, Employee exists
            if (resultSet.Count() > 0)
            {
                return true;
            }
            return false;
        }
        // Add Airline to the Airline List
        public static bool AddAirline(Airline data)
        {
            int OldCount = airlines.Count();
            if (findAirlineByID(data.ID))
            {
                var id = data.ID;
                data.ID = AirlineID_generator(id);
            }
            airlines.Add(data);
            int newCount = airlines.Count();
            if (newCount > OldCount)
            {
                return true;
            }
            return false;
        }
        // UPDATE THE AIRLINE
        public static bool UpdateAirline(Airline data)
        {
            if (findAirlineByID(data.ID))
            {
                var AL = from e in airlines where e.ID == data.ID select e;
                foreach (var airline in AL)
                {
                    airline.Name = data.Name;
                    airline.Airplane = data.Airplane;
                    airline.seatsAvailable = data.seatsAvailable;
                    airline.mealsAvailable = data.mealsAvailable;

                }
                return true;
            }

            return false;
        }
        //Delete Airline
        public static void deleteAirline(int airlineID)
        {
            airlines = airlines.Except(from c in airlines where c.ID == airlineID select c).ToList();
        }
        //Populate Airlines List With Pre-defined Data
        public static void populateAirlinesData()
        {
            AddAirline(new Airline { ID = 1, Name = "Boeing", Airplane = "Boeing 777", seatsAvailable = 60, mealsAvailable = "Chicken" });
            AddAirline(new Airline { ID = 2, Name = "Air India", Airplane = "India 2375", seatsAvailable = 77, mealsAvailable = "Salad" });
            AddAirline(new Airline { ID = 3, Name = "Etihad", Airplane = "Ethihad 100", seatsAvailable = 90, mealsAvailable = "Sushi" });
            AddAirline(new Airline { ID = 4, Name = "Ethihad", Airplane = "Ethihad 100", seatsAvailable = 50, mealsAvailable = "Chicken" });
            AddAirline(new Airline { ID = 5, Name = "Air Canada", Airplane = "Canada 270", seatsAvailable = 200, mealsAvailable = "Salad" });
        }
    }
}
