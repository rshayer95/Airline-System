using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFApp
{
    class CustomerHelper
    {
        public static List<Customer> customers = new List<Customer>();
        // CUSTOMER ID GENERATOR
        public static int CustomerID_generator(int id)
        {
            return id + 1;
        }
        //Check if Customer exists
        public static bool findCustomerByID(int id)
        {
            var resultSet = from customer in customers where customer.ID == id select customer;
            //If ResultSet has data, Employee exists
            if (resultSet.Count() > 0)
            {
                return true;
            }
            return false;
        }
        // Add Customer to the Customer List
        public static bool AddCustomer(Customer data)
        {
            int OldCount = customers.Count();
            if (findCustomerByID(data.ID))
            {
                var id = data.ID;
                data.ID = CustomerID_generator(id);
            }
            customers.Add(data);
            int newCount = customers.Count();
            if (newCount > OldCount)
            {
                return true;
            }
            return false;
        }
        // UPDATE THE EMPLOYEE
        public static bool UpdateCustomer(Customer data)
        {
            if (findCustomerByID(data.ID))
            {
                var Customers = from e in customers where e.ID == data.ID select e;
                foreach (var customer in Customers)
                {
                    customer.Name = data.Name;
                    customer.Address = data.Address;
                    customer.Email = data.Email;
                    customer.Phone = data.Phone;
                    
                }
                return true;
            }

            return false;
        }
        //Delete Customer
        public static void deleteCustomer(int customerID)
        {
            customers = customers.Except(from c in customers where c.ID == customerID select c).ToList();
        }
        //Populate Customer List With Pre-defined Data
        public static void populateCustomersData()
        {
            AddCustomer(new Customer {ID= 1, Name= "Tracy", Address="Toronto", Email="tracy@gmail.com", Phone="+18978430987" });
            AddCustomer(new Customer { ID = 2, Name = "Robin", Address = "Brampton", Email = "robin@live.com", Phone = "+18978430988" });
            AddCustomer(new Customer { ID = 3, Name = "Greig", Address = "Mississauga", Email = "grieg@yahoo.com", Phone = "+18978430989" });
            AddCustomer(new Customer { ID = 4, Name = "Ali", Address = "Malton", Email = "ali@proton.com", Phone = "+18978430990" });
            AddCustomer(new Customer { ID = 5, Name = "Lisa", Address = "Berrie", Email = "lisa@hotmail.com", Phone = "+18978430991" });
        }
    }
}
