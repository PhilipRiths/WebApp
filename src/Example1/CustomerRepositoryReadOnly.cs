using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Example1
{
    public class CustomerRepositoryReadOnly : ICustomerRepositoryReadOnly
    {
        
        public List<Customer> Customers;

        public void PopulateCustomer()
        {
            Customers = new List<Customer>();
            var customerStrings = File.ReadAllLines("Repository/PersonShort.csv");

            foreach (var customerstring in customerStrings)
            {
                var customerProperties = customerstring.Split(',');


                Customer customer = new Customer();
                {

                  
                    customer.Id = int.Parse(customerProperties[0]);
                    customer.FirstName = customerProperties[1];
                    customer.LastName = customerProperties[2];
                    customer.Email = customerProperties[3];
                    customer.Gender = customerProperties[4];
                    customer.Age = int.Parse(customerProperties[5]);

                }
                Customers.Add(customer);

            }


        }

        public IEnumerable<Customer> GetAll()
        {
            return Customers;
        }

        public Customer GetById(int id)
        {
           return Customers.Find(x => x.Id == id);
        }

        public bool CustomerExist(int id)
        {
            return Customers.Any(customer => customer.Id == id);
        }
    }
}
