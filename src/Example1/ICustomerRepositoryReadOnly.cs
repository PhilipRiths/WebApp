using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Example1
{

    public interface ICustomerRepositoryReadOnly
    {
        IEnumerable<Customer> GetAll();
        Customer GetById(int id);
        bool CustomerExist(int id);

        void PopulateCustomer();
    }
}

